using System;
using System.Collections;
using System.Collections.Generic;
using FairyGUI;
using UnityEngine;
using UnityEngine.Networking;
using Net = Client.MirNetwork.Network;
using C = ClientPackets;
using Client.MirControls;
using Client.MirScenes;

namespace Client
{
public sealed class FguiBootstrap : MonoBehaviour
{
    private static FguiBootstrap _instance;

    private static GObject _rootView;
    private static GObject _currentPanel;
    private static GLoader _background;
    private static bool _currentPanelFullscreen;
    private static bool _currentPanelFitToScreen;
    private static float _currentPanelScaleMultiplier = 1.0f;
    private static bool _loggedLoadingResItems;
    private static GComponent _characterSelect;
    private static bool _characterSelectIsPackagedUI;
    private static GGraph _characterSelectBackdrop;
    private static List<SelectInfo> _characters;
    private static int _selectedCharacterIndex;
    private static GComponent _createCharacter;
    private static MirClass _newCharClass = MirClass.Warrior;
    private static MirGender _newCharGender = MirGender.Male;

    // 服务器配置
    private static ServerConfig _serverConfig;
    private static ServerInfo _selectedServer;

    [SerializeField] private string packageName = "Login";
    [SerializeField] private string componentName = "logint_ui";

    [SerializeField] private string firstPanelPackage = "Login";
    [SerializeField] private string firstPanelComponent = "logint_ui";

    private static readonly string[] LoginKeywords =
    {
        "login",
        "登录",
        "log in",
        "server",
        "选服",
        "scan",
        "扫码",
        "realname",
        "实名",
        "serverSel",
        "serversel",
        "dserversel",
        "loginui",
        "accountlogin",
    };

    private static readonly string[] PreferredLoginComponents =
    {
        "logint_ui",      // 新的登录界面（UI_1）
        "PC登录_LoginUI",
        "PC登录2_LoginUI2",
        "登录_LoginUI",
    };

    private static readonly string[] DefaultPackagePaths =
    {
        "UI_1/common",   // 新的公共资源包
        "UI_1/ui_2",     // 新的登录包（实际名称是 Login）
        "UI_1/Select",   // 选服包（包含 Prefecture 和 Enlist）
        "UI_1/NPC",      // NPC 对话框
        "UI_1/home",     // 背包、游戏内 UI
    };

    private static readonly string[] DefaultPackageNames =
    {
        "common",        // 新的公共包
        "ui_2",          // 新的登录包
        "BaseRes",
        "Font",
        "Sounds",
        "UILoadingRes",
        "UILoading",
        "UIRes",
        "UI",
        "FormId",
        "自定义组件",
    };

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
    }

    private void Start()
    {
        try
        {
            DiagnoseAndFixDuplicateRendering();

            SetStageCameraBackgroundBlack();

            StartCoroutine(DelayedDuplicateFix());
            StartCoroutine(FetchServerListCoroutine());

            for (int i = 0; i < DefaultPackagePaths.Length; i++)
            {
                try
                {
                    UIPackage.AddPackage(DefaultPackagePaths[i]);
                    Debug.Log($"[FguiBootstrap] ✓ Loaded package: {DefaultPackagePaths[i]}");
                }
                catch (Exception ex)
                {
                    Debug.LogWarning($"[FguiBootstrap] ✗ Failed to load package: {DefaultPackagePaths[i]}, error: {ex.Message}");
                }
            }

            // 绑定 Login 包的自定义组件
            try
            {
                Login.LoginBinder.BindAll();
                Debug.Log("[FguiBootstrap] ✓ LoginBinder.BindAll() called");
            }
            catch (Exception ex)
            {
                Debug.LogWarning($"[FguiBootstrap] ✗ Failed to bind Login components: {ex.Message}");
            }

            // 绑定 Select 包的自定义组件
            try
            {
                Select.SelectBinder.BindAll();
                Debug.Log("[FguiBootstrap] ✓ SelectBinder.BindAll() called");
            }
            catch (Exception ex)
            {
                Debug.LogWarning($"[FguiBootstrap] ✗ Failed to bind Select components: {ex.Message}");
            }

            try
            {
                Common.CommonBinder.BindAll();
                Debug.Log("[FguiBootstrap] ✓ CommonBinder.BindAll() called");
            }
            catch (Exception ex)
            {
                Debug.LogWarning($"[FguiBootstrap] ✗ Failed to bind Common components: {ex.Message}");
            }

            try
            {
                NPC.NPCBinder.BindAll();
                Debug.Log("[FguiBootstrap] ✓ NPCBinder.BindAll() called");
            }
            catch (Exception ex)
            {
                Debug.LogWarning($"[FguiBootstrap] ✗ Failed to bind NPC components: {ex.Message}");
            }

            try
            {
                home.homeBinder.BindAll();
                Debug.Log("[FguiBootstrap] ✓ homeBinder.BindAll() called");
            }
            catch (Exception ex)
            {
                Debug.LogWarning($"[FguiBootstrap] ✗ Failed to bind home components: {ex.Message}");
            }

            // UI_1 only - no legacy UI packages needed
            // 注意：现在启动时直接显示选区界面，不需要查找登录组件

            if (GRoot.inst != null)
                GRoot.inst.RemoveChildren(0, -1, true);

            CreateBackground();

            // Ensure network begins connecting even without legacy LoginScene.
            MirScene.ActiveScene = new FguiBridgeScene();

            // 游戏启动时直接显示登录界面
            ShowLoginUI();

            Stage.inst.onStageResized.Remove(OnStageResized);
            Stage.inst.onStageResized.Add(OnStageResized);
        }
        catch (Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    public static void ClearAllUI()
    {
        try
        {
            _currentPanel?.RemoveFromParent();
            _currentPanel?.Dispose();
            _currentPanel = null;

            _characterSelectBackdrop?.RemoveFromParent();
            _characterSelectBackdrop?.Dispose();
            _characterSelectBackdrop = null;

            _characterSelect?.RemoveFromParent();
            _characterSelect?.Dispose();
            _characterSelect = null;

            _background?.RemoveFromParent();
            _background?.Dispose();
            _background = null;

            if (GRoot.inst != null)
                GRoot.inst.RemoveChildren(0, -1, true);
        }
        catch
        {
        }
    }

    public static void ShowToast(string text)
    {
        try
        {
            if (GRoot.inst == null)
                return;

            GComponent toast = new GComponent();
            toast.touchable = false;
            GRoot.inst.AddChild(toast);

            GTextField tf = new GTextField { text = text ?? string.Empty };
            var tfmt = tf.textFormat;
            tfmt.size = 24;
            tfmt.color = Color.white;
            tf.textFormat = tfmt;
            toast.AddChild(tf);
            tf.SetSize(800, 60);

            GGraph bg = new GGraph();
            toast.AddChildAt(bg, 0);
            bg.DrawRect(820, 70, 0, Color.clear, new Color(0, 0, 0, 0.7f));

            toast.SetSize(bg.width, bg.height);
            toast.SetPivot(0.5f, 0.5f);
            toast.x = GRoot.inst.width * 0.5f;
            toast.y = GRoot.inst.height * 0.15f;

            Timers.inst.Add(2.0f, 1, _ =>
            {
                toast.RemoveFromParent();
                toast.Dispose();
            });
        }
        catch
        {
        }
    }

    public static void ShowDialog(string message, System.Action onOk = null)
    {
        try
        {
            if (GRoot.inst == null) return;

            // 用 URL 精确定位外层对话框，避免与同包内同名内部按钮冲突
            // （CreateObject("Common","Button_Transparency") 会找到内部 GButton，不是对话框）
            Common.UI_Button_Transparency dialog =
                UIPackage.CreateObjectFromURL(Common.UI_Button_Transparency.URL) as Common.UI_Button_Transparency;

            if (dialog == null) { ShowToast(message); return; }

            if (dialog.m_test != null)
                dialog.m_test.text = message;

            const float dialogScale = 3.0f;
            dialog.SetScale(dialogScale, dialogScale);

            GRoot.inst.AddChild(dialog);
            dialog.SetXY(
                (GRoot.inst.width  - dialog.width  * dialogScale) / 2,
                (GRoot.inst.height - dialog.height * dialogScale) / 2);

            dialog.m_ok.onClick.Clear();
            dialog.m_ok.onClick.Add(() =>
            {
                dialog.RemoveFromParent();
                dialog.Dispose();
                onOk?.Invoke();
            });
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] ShowDialog failed: {ex.Message}\n{ex.StackTrace}");
            ShowToast(message);
        }
    }

    public static void AddCharacterAndRefresh(SelectInfo charInfo)
    {
        if (_characters == null) _characters = new List<SelectInfo>();
        _characters.Insert(0, charInfo);
        ShowCharacterSelect(_characters);
    }

    public static void ShowCharacterSelect(List<SelectInfo> characters)
    {
        Debug.Log($"[FguiBootstrap] ShowCharacterSelect called with {characters?.Count ?? 0} characters");

        _characters = characters ?? new List<SelectInfo>();
        _selectedCharacterIndex = 0;

        if (_background != null)
            _background.visible = false;  // 隐藏登录背景，使用选角界面自己的背景

        _characterSelectIsPackagedUI = false;

        // 暂时不添加黑色背景层，等待看是否需要
        // EnsureCharacterSelectBackdrop();

        if (_characterSelect != null)
        {
            _characterSelect.RemoveFromParent();
            _characterSelect.Dispose();
            _characterSelect = null;
        }

        // Hide current panel (server select/login) and show a simple character selection overlay.
        _currentPanel?.RemoveFromParent();
        _currentPanel?.Dispose();
        _currentPanel = null;

        // Prefer the real FGUI character select UI if present in the loaded packages.
        if (!TryShowFairyGuiCharacterSelect())
        {
            Debug.LogWarning("[FguiBootstrap] FairyGUI character select failed, using fallback UI");
            // 旧的回退 UI 需要黑色背景
            EnsureCharacterSelectBackdrop();
            _characterSelect = BuildCharacterSelectPanel();
            GRoot.inst.AddChild(_characterSelect);
            CenterPanel(_characterSelect);
        }
    }

    private static bool TryShowFairyGuiCharacterSelect()
    {
        try
        {
            Debug.Log("[FguiBootstrap] TryShowFairyGuiCharacterSelect called");

            // Try new UI_1 character select first - try Select _character_1 first, then fallback to Select _character
            GObject view = UIPackage.CreateObject("Login", "Select _character_1");
            if (view == null)
            {
                Debug.LogWarning("[FguiBootstrap] Failed to create 'Select _character_1', trying Select _character");
                view = UIPackage.CreateObject("Login", "Select _character");
            }
            else
            {
                Debug.Log("[FguiBootstrap] Successfully created 'Select _character_1' from Login package");
            }

            if (view == null)
            {
                Debug.LogWarning("[FguiBootstrap] Failed to create any Select _character component, trying old UI");
                // Fallback to old UI if exists
                view = UIPackage.CreateObject("UI", "选角_CharSelectUI");
            }

            if (view == null)
            {
                Debug.LogError("[FguiBootstrap] Failed to create any character select UI");
                return false;
            }

            GComponent panel = view.asCom;
            if (panel == null)
            {
                Debug.LogError("[FguiBootstrap] Character select view is not a GComponent");
                view.Dispose();
                return false;
            }

            _characterSelect = panel;
            _characterSelectIsPackagedUI = true;

            // 新 UI_1 有自己的背景，不需要额外的黑色背景层
            // EnsureCharacterSelectBackdrop();
            GRoot.inst.AddChild(_characterSelect);
            FitCharacterSelectToScreen(_characterSelect);

            Debug.Log($"[FguiBootstrap] Character select UI added to stage, size: {panel.width}x{panel.height}");

            BindFairyGuiCharacterSelect(panel);
            RefreshFairyGuiCharacterSelect(panel);
            return true;
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to show character select: {ex.Message}\n{ex.StackTrace}");
            return false;
        }
    }

    private static void BindFairyGuiCharacterSelect(GComponent panel)
    {
        try
        {
            // Try new UI_1 button names first (start_Game)
            GObject startBtn = panel.GetChild("start_Game");
            if (startBtn == null)
            {
                // Fallback to old UI button name
                startBtn = panel.GetChild("DStart");
            }

            if (startBtn != null)
            {
                startBtn.onClick.Clear();
                startBtn.onClick.Add(() =>
                {
                    if (_characters == null || _characters.Count == 0)
                    {
                        ShowToast("没有角色");
                        return;
                    }
                    if (_selectedCharacterIndex < 0 || _selectedCharacterIndex >= _characters.Count)
                        _selectedCharacterIndex = 0;

                    Net.Enqueue(new C.StartGame { CharacterIndex = _characters[_selectedCharacterIndex].Index });
                    ShowToast("正在进入游戏...");
                });
                Debug.Log("[FguiBootstrap] Bound start_Game button for character select");
            }

            // Bind Create_characters button (创建人物)
            GObject createBtn = panel.GetChild("Create_characters");
            if (createBtn != null)
            {
                createBtn.onClick.Clear();
                createBtn.onClick.Add(() =>
                {
                    ShowCreateCharacterDialog();
                });
                Debug.Log("[FguiBootstrap] Bound Create_characters button");
            }

            // Bind Person_1 and Person_2 selection buttons (人物1和人物2选择按钮)
            GObject person1Btn = panel.GetChild("Person_1");
            if (person1Btn != null)
            {
                person1Btn.onClick.Clear();
                person1Btn.onClick.Add(() =>
                {
                    _selectedCharacterIndex = 0;
                    RefreshFairyGuiCharacterSelect(panel);
                    Debug.Log("[FguiBootstrap] Selected character 1");
                });
                Debug.Log("[FguiBootstrap] Bound Person_1 button");
            }

            GObject person2Btn = panel.GetChild("Person_2");
            if (person2Btn != null)
            {
                person2Btn.onClick.Clear();
                person2Btn.onClick.Add(() =>
                {
                    _selectedCharacterIndex = 1;
                    RefreshFairyGuiCharacterSelect(panel);
                    Debug.Log("[FguiBootstrap] Selected character 2");
                });
                Debug.Log("[FguiBootstrap] Bound Person_2 button");
            }

            // Bind Delete_character button (删除人物按钮)
            GObject deleteBtn = panel.GetChild("Delete_character");
            if (deleteBtn != null)
            {
                deleteBtn.onClick.Clear();
                deleteBtn.onClick.Add(() =>
                {
                    DeleteCharacter();
                });
                Debug.Log("[FguiBootstrap] Bound Delete_character button");
            }

            // Old UI had selection buttons, new UI_1 doesn't need them (only shows one character)
            GButton sel1 = panel.GetChild("DBtnSel1")?.asButton;
            if (sel1 != null)
            {
                sel1.onClick.Clear();
                sel1.onClick.Add(() =>
                {
                    _selectedCharacterIndex = 0;
                    RefreshFairyGuiCharacterSelect(panel);
                });
            }

            GButton sel2 = panel.GetChild("DBtnSel2")?.asButton;
            if (sel2 != null)
            {
                sel2.onClick.Clear();
                sel2.onClick.Add(() =>
                {
                    _selectedCharacterIndex = 1;
                    RefreshFairyGuiCharacterSelect(panel);
                });
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to bind character select: {ex.Message}");
        }
    }

    private static void LoadCharacterPortrait(GComponent panel, SelectInfo character)
    {
        try
        {
            if (character == null)
                return;

            GLoader portraitLoader = panel.GetChild("n9")?.asLoader;
            if (portraitLoader == null)
                return;

            // 根据职业和性别确定肖像图片名称
            // fs = 法师, ws = 战士, ds = 道士
            // _1 = 男, _2 = 女
            string portraitName = "";
            string classPrefix = "";

            switch (character.Class)
            {
                case MirClass.Warrior:
                    classPrefix = "ws";
                    break;
                case MirClass.Wizard:
                    classPrefix = "fs";
                    break;
                case MirClass.Taoist:
                    classPrefix = "ds";
                    break;
                default:
                    classPrefix = "ws";
                    break;
            }

            string genderSuffix = character.Gender == MirGender.Male ? "1" : "2";
            portraitName = $"{classPrefix}_{genderSuffix}";

            // 从 Login 包加载肖像图片
            string url = UIPackage.GetItemURL("Login", portraitName);
            if (!string.IsNullOrEmpty(url))
            {
                portraitLoader.url = url;
                Debug.Log($"[FguiBootstrap] Loaded character portrait: {portraitName}");
            }
            else
            {
                Debug.LogWarning($"[FguiBootstrap] Failed to load character portrait: {portraitName}");
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to load character portrait: {ex.Message}");
        }
    }

    private static void RefreshFairyGuiCharacterSelect(GComponent panel)
    {
        try
        {
            void SetText(string childName, string value)
            {
                GObject obj = panel.GetChild(childName);
                if (obj is GTextField tf)
                    tf.text = value ?? string.Empty;
                else if (obj is GTextInput ti)
                    ti.text = value ?? string.Empty;
            }

            SelectInfo currentChar = null;
            if (_characters != null && _characters.Count > 0)
            {
                if (_selectedCharacterIndex < 0 || _selectedCharacterIndex >= _characters.Count)
                    _selectedCharacterIndex = 0;
                currentChar = _characters[_selectedCharacterIndex];
            }

            // Try new UI_1 field names first (name_1=名字, Level_1=等级, Occupation_1=职业, Gender_1=性别)
            GObject nameField = panel.GetChild("name_1");
            GObject levelField = panel.GetChild("Level_1");
            GObject classField = panel.GetChild("Occupation_1");
            GObject genderField = panel.GetChild("Gender_1");

            if (nameField != null || levelField != null || classField != null)
            {
                // New UI_1 layout - supports two character slots (人物1 and 人物2)
                SelectInfo char1 = _characters != null && _characters.Count > 0 ? _characters[0] : null;
                SelectInfo char2 = _characters != null && _characters.Count > 1 ? _characters[1] : null;

                // 人物1 (Character slot 1)
                SetText("name_1", char1?.Name);
                SetText("Level_1", char1 != null ? $"Lv.{char1.Level}" : string.Empty);
                SetText("Occupation_1", char1 != null ? GetClassNameChinese(char1.Class) : string.Empty);
                if (char1 != null)
                {
                    string genderText = char1.Gender == MirGender.Male ? "男" : "女";
                    SetText("Gender_1", genderText);
                }
                else
                {
                    SetText("Gender_1", string.Empty);
                }

                // 人物2 (Character slot 2) - check if these fields exist
                GObject nameField2 = panel.GetChild("name_2");
                if (nameField2 != null)
                {
                    SetText("name_2", char2?.Name);
                    SetText("Level_2", char2 != null ? $"Lv.{char2.Level}" : string.Empty);
                    SetText("Occupation_2", char2 != null ? GetClassNameChinese(char2.Class) : string.Empty);
                    if (char2 != null)
                    {
                        string genderText = char2.Gender == MirGender.Male ? "男" : "女";
                        SetText("Gender_2", genderText);
                    }
                    else
                    {
                        SetText("Gender_2", string.Empty);
                    }
                }

                // 加载角色肖像
                // n9: 人物1的肖像, n30: 人物2的肖像
                GLoader portrait1 = panel.GetChild("n9")?.asLoader;
                if (portrait1 != null && char1 != null)
                {
                    string classPrefix = char1.Class == MirClass.Warrior ? "ws" :
                                        char1.Class == MirClass.Wizard ? "fs" : "ds";
                    string genderSuffix = char1.Gender == MirGender.Male ? "1" : "2";
                    string portraitName = $"{classPrefix}_{genderSuffix}";
                    string url = UIPackage.GetItemURL("Login", portraitName);
                    if (!string.IsNullOrEmpty(url))
                    {
                        portrait1.url = url;
                    }
                }
                else if (portrait1 != null)
                {
                    portrait1.url = null;  // Clear if no character
                }

                GLoader portrait2 = panel.GetChild("n30")?.asLoader;
                if (portrait2 != null && char2 != null)
                {
                    string classPrefix = char2.Class == MirClass.Warrior ? "ws" :
                                        char2.Class == MirClass.Wizard ? "fs" : "ds";
                    string genderSuffix = char2.Gender == MirGender.Male ? "1" : "2";
                    string portraitName = $"{classPrefix}_{genderSuffix}";
                    string url = UIPackage.GetItemURL("Login", portraitName);
                    if (!string.IsNullOrEmpty(url))
                    {
                        portrait2.url = url;
                    }
                }
                else if (portrait2 != null)
                {
                    portrait2.url = null;  // Clear if no character
                }

                // 高亮选中的角色按钮 (Highlight selected character button)
                GObject person1Btn = panel.GetChild("Person_1");
                if (person1Btn != null)
                {
                    // 选中状态：高亮 + 放大，未选中状态：变暗 + 正常大小
                    person1Btn.alpha = _selectedCharacterIndex == 0 ? 1f : 0.5f;
                    person1Btn.SetScale(_selectedCharacterIndex == 0 ? 1.1f : 1f, _selectedCharacterIndex == 0 ? 1.1f : 1f);
                }

                GObject person2Btn = panel.GetChild("Person_2");
                if (person2Btn != null)
                {
                    // 选中状态：高亮 + 放大，未选中状态：变暗 + 正常大小
                    person2Btn.alpha = _selectedCharacterIndex == 1 ? 1f : 0.5f;
                    person2Btn.SetScale(_selectedCharacterIndex == 1 ? 1.1f : 1f, _selectedCharacterIndex == 1 ? 1.1f : 1f);
                }

                Debug.Log($"[FguiBootstrap] Character select refreshed (UI_1): Char1={char1?.Name}, Char2={char2?.Name}, Selected={_selectedCharacterIndex}");
            }
            else
            {
                // Old UI layout (two characters side by side)
                SelectInfo c1 = _characters != null && _characters.Count > 0 ? _characters[0] : null;
                SelectInfo c2 = _characters != null && _characters.Count > 1 ? _characters[1] : null;

                SetText("DName1", c1?.Name);
                SetText("DLevel1", c1 != null ? $"Lv.{c1.Level}" : string.Empty);
                SetText("DJob1", c1 != null ? GetClassNameChinese(c1.Class) : string.Empty);

                SetText("DName2", c2?.Name);
                SetText("DLevel2", c2 != null ? $"Lv.{c2.Level}" : string.Empty);
                SetText("DJob2", c2 != null ? GetClassNameChinese(c2.Class) : string.Empty);

                // Subtle highlight via button alpha if buttons exist.
                GButton sel1 = panel.GetChild("DBtnSel1")?.asButton;
                if (sel1 != null) sel1.alpha = _selectedCharacterIndex == 0 ? 1f : 0.65f;
                GButton sel2 = panel.GetChild("DBtnSel2")?.asButton;
                if (sel2 != null) sel2.alpha = _selectedCharacterIndex == 1 ? 1f : 0.65f;
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to refresh character select: {ex.Message}");
        }
    }

    private static GComponent BuildCharacterSelectPanel()
    {
        GComponent panel = new GComponent();
        panel.SetSize(700, 520);

        GGraph bg = new GGraph();
        panel.AddChild(bg);
        bg.DrawRect(panel.width, panel.height, 2, new Color(1f, 0.84f, 0.47f, 1f), new Color(0, 0, 0, 0.75f));

        GTextField title = new GTextField { text = "选择角色" };
        var titleFmt = title.textFormat;
        titleFmt.size = 28;
        titleFmt.color = Color.white;
        title.textFormat = titleFmt;
        panel.AddChild(title);
        title.SetXY(20, 14);
        title.SetSize(300, 40);

        int startY = 70;
        int rowH = 44;

        for (int i = 0; i < Math.Min(6, _characters.Count); i++)
        {
            int idx = i;
            SelectInfo ch = _characters[i];

            GGraph rowBg = new GGraph();
            panel.AddChild(rowBg);
            rowBg.SetXY(20, startY + idx * rowH);
            rowBg.SetSize(660, rowH - 6);
            rowBg.DrawRect(rowBg.width, rowBg.height, 1, new Color(1f, 1f, 1f, 0.25f), new Color(1f, 1f, 1f, 0.10f));
            rowBg.touchable = true;
            rowBg.onClick.Add(() =>
            {
                _selectedCharacterIndex = idx;
                RefreshCharacterSelect(panel);
            });

            GTextField rowText = new GTextField { text = $"{ch.Name}   Lv.{ch.Level}   {GetClassNameChinese(ch.Class)}" };
            var rowFmt = rowText.textFormat;
            rowFmt.size = 22;
            rowFmt.color = Color.white;
            rowText.textFormat = rowFmt;
            panel.AddChild(rowText);
            rowText.SetXY(34, startY + idx * rowH + 6);
            rowText.SetSize(640, rowH);
            rowText.touchable = false;
        }

        GGraph startBtn = new GGraph();
        panel.AddChild(startBtn);
        startBtn.SetSize(200, 50);
        startBtn.SetXY(panel.width - 220, panel.height - 70);
        startBtn.DrawRect(startBtn.width, startBtn.height, 2, new Color(1f, 0.84f, 0.47f, 1f), new Color(0.23f, 0.23f, 0.23f, 0.85f));
        startBtn.touchable = true;
        startBtn.onClick.Add(() =>
        {
            if (_characters == null || _characters.Count == 0)
            {
                ShowToast("没有角色");
                return;
            }
            if (_selectedCharacterIndex < 0 || _selectedCharacterIndex >= _characters.Count)
                _selectedCharacterIndex = 0;

            Net.Enqueue(new C.StartGame { CharacterIndex = _characters[_selectedCharacterIndex].Index });
            ShowToast("正在进入游戏...");
        });

        GTextField startText = new GTextField { text = "进入游戏" };
        var startFmt = startText.textFormat;
        startFmt.size = 24;
        startFmt.color = Color.white;
        startText.textFormat = startFmt;
        panel.AddChild(startText);
        startText.SetXY(startBtn.x + 40, startBtn.y + 12);
        startText.SetSize(200, 40);
        startText.touchable = false;

        RefreshCharacterSelect(panel);
        return panel;
    }

    private static void RefreshCharacterSelect(GComponent panel)
    {
        // highlight selected row by changing alpha on the row backgrounds
        int startY = 70;
        int rowH = 44;
        for (int i = 0; i < Math.Min(6, _characters.Count); i++)
        {
            // Row backgrounds are added first, after title: index 1 is bg, 2 is title, then rows
            // Safer: find by position
            float y = startY + i * rowH;
            for (int c = 0; c < panel.numChildren; c++)
            {
                if (panel.GetChildAt(c) is GGraph g && Math.Abs(g.y - y) < 0.1f && Math.Abs(g.width - 660) < 0.1f)
                {
                    g.alpha = i == _selectedCharacterIndex ? 0.9f : 0.5f;
                }
            }
        }
    }

    private static void CreateBackground()
    {
        if (_background != null)
            return;

        // Try new UI_1 backgrounds first, then fallback to old UI
        string url = null;
        string[] newCandidates =
        {
            "home_ui_background",
            "Login_Background",
        };

        // Try new UI_1 Common package first
        for (int i = 0; i < newCandidates.Length; i++)
        {
            url = UIPackage.GetItemURL("Common", newCandidates[i]);
            if (!string.IsNullOrEmpty(url))
            {
                Debug.Log($"[FguiBootstrap] Using new UI_1 background: {newCandidates[i]}");
                break;
            }
        }

        if (string.IsNullOrEmpty(url))
        {
            Debug.LogError("[FguiBootstrap] Background url not found in Common package");
            LogPackageImageItemsOnce("Common");
            return;
        }

        Debug.Log($"[FguiBootstrap] Background url: {url}");

        _background = new GLoader
        {
            url = url,
            fill = FillType.Scale,
            align = AlignType.Center,
            verticalAlign = VertAlignType.Middle,
            touchable = false
        };

        GRoot.inst.AddChildAt(_background, 0);
        _background.SetSize(GRoot.inst.width, GRoot.inst.height);
    }

    private static void LogPackageImageItemsOnce(string packageName)
    {
        if (_loggedLoadingResItems)
            return;
        _loggedLoadingResItems = true;

        try
        {
            UIPackage pkg = UIPackage.GetByName(packageName);
            if (pkg == null)
            {
                Debug.LogError($"[FguiBootstrap] Package not loaded: {packageName}");
                return;
            }

            List<PackageItem> items = pkg.GetItems();
            if (items == null)
                return;

            Debug.Log($"[FguiBootstrap] Dump exported image items in package '{packageName}':");
            for (int i = 0; i < items.Count; i++)
            {
                var it = items[i];
                if (it == null) continue;
                if (!it.exported) continue;
                if (it.type != PackageItemType.Image) continue;
                Debug.Log($"[FguiBootstrap]   image: {it.name}");
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Dump package items failed: {packageName}, ex={ex.Message}");
        }
    }

    private static void OnStageResized(EventContext context)
    {
        if (_background != null)
            _background.SetSize(GRoot.inst.width, GRoot.inst.height);

        if (_characterSelectBackdrop != null)
            _characterSelectBackdrop.SetSize(GRoot.inst.width, GRoot.inst.height);

        if (_characterSelect != null && _characterSelectIsPackagedUI)
            FitCharacterSelectToScreen(_characterSelect);

        if (_currentPanel != null)
        {
            if (_currentPanelFullscreen && _currentPanel is GComponent comp)
                comp.SetSize(GRoot.inst.width, GRoot.inst.height);
            else if (_currentPanelFitToScreen || _currentPanelScaleMultiplier != 1.0f)
                FitToScreenWithScale(_currentPanel, _currentPanelScaleMultiplier);
            else
                CenterPanel(_currentPanel);
        }
    }

    private static bool IsLoginPackage(string pkg)
    {
        return string.Equals(pkg, "UILoading", StringComparison.OrdinalIgnoreCase)
               || string.Equals(pkg, "UILoadingRes", StringComparison.OrdinalIgnoreCase)
               || string.Equals(pkg, "Login", StringComparison.OrdinalIgnoreCase);
    }

    private static void FitToScreen(GObject obj)
    {
        FitToScreenWithScale(obj, 1.0f);
    }

    private static void FitToScreenWithScale(GObject obj, float scaleMultiplier)
    {
        if (obj == null || GRoot.inst == null)
            return;

        float designW = obj.width;
        float designH = obj.height;
        if (designW <= 0 || designH <= 0)
            return;

        float sx = GRoot.inst.width / designW;
        float sy = GRoot.inst.height / designH;
        float scale = Mathf.Min(sx, sy) * scaleMultiplier;

        obj.scaleX = scale;
        obj.scaleY = scale;

        float w = designW * scale;
        float h = designH * scale;
        obj.SetPivot(0, 0);
        obj.SetXY((GRoot.inst.width - w) * 0.5f, (GRoot.inst.height - h) * 0.5f);
    }

    private static void FitCharacterSelectToScreen(GComponent panel)
    {
        if (panel == null || GRoot.inst == null)
            return;

        // Packaged character select is designed at 1280x720 and doesn't stretch its internal display list.
        // We scale the whole panel to fill the stage.
        float designW = panel.width;
        float designH = panel.height;
        if (designW <= 0 || designH <= 0)
        {
            panel.SetXY(0, 0);
            return;
        }

        float sx = GRoot.inst.width / designW;
        float sy = GRoot.inst.height / designH;

        // Keep aspect ratio to avoid stretching the art.
        float scale = Mathf.Min(sx, sy);
        panel.scaleX = scale;
        panel.scaleY = scale;

        float w = designW * scale;
        float h = designH * scale;
        panel.SetXY((GRoot.inst.width - w) * 0.5f, (GRoot.inst.height - h) * 0.5f);
    }

    private static void SetStageCameraBackgroundBlack()
    {
        try
        {
            var cams = UnityEngine.Object.FindObjectsOfType<FairyGUI.StageCamera>(true);
            for (int i = 0; i < cams.Length; i++)
            {
                var cam = cams[i] != null ? cams[i].GetComponent<Camera>() : null;
                if (cam == null) continue;
                cam.clearFlags = CameraClearFlags.SolidColor;
                cam.backgroundColor = Color.black;
            }
        }
        catch
        {
        }
    }

    private static void EnsureCharacterSelectBackdrop()
    {
        if (GRoot.inst == null)
            return;

        if (_characterSelectBackdrop == null)
        {
            _characterSelectBackdrop = new GGraph();
            _characterSelectBackdrop.touchable = false;
            GRoot.inst.AddChildAt(_characterSelectBackdrop, 0);
        }

        _characterSelectBackdrop.SetXY(0, 0);
        _characterSelectBackdrop.SetSize(GRoot.inst.width, GRoot.inst.height);
        _characterSelectBackdrop.DrawRect(GRoot.inst.width, GRoot.inst.height, 0, Color.clear, Color.black);
    }

    private static void ShowPanelFullScreen(string pkg, string comp)
    {
        if (string.IsNullOrEmpty(pkg) || string.IsNullOrEmpty(comp))
            return;

        _characterSelectBackdrop?.RemoveFromParent();
        _characterSelectBackdrop?.Dispose();
        _characterSelectBackdrop = null;

        if (_background != null)
            _background.visible = true;

        if (_currentPanel != null)
        {
            _currentPanel.RemoveFromParent();
            _currentPanel.Dispose();
            _currentPanel = null;
        }
        _currentPanelFullscreen = true;
        _currentPanelFitToScreen = false;

        GObject view = UIPackage.CreateObject(pkg, comp);
        if (view == null)
        {
            Debug.LogError($"[FguiBootstrap] CreateObject failed. packageName={pkg}, componentName={comp}");
            return;
        }

        GRoot.inst.AddChild(view);
        _currentPanel = view;

        if (view is GComponent gc)
            gc.SetSize(GRoot.inst.width, GRoot.inst.height);
    }

    private static void ShowPanelCentered(string pkg, string comp)
    {
        if (string.IsNullOrEmpty(pkg) || string.IsNullOrEmpty(comp))
            return;

        _characterSelectBackdrop?.RemoveFromParent();
        _characterSelectBackdrop?.Dispose();
        _characterSelectBackdrop = null;

        if (_background != null)
            _background.visible = true;

        if (_currentPanel != null)
        {
            _currentPanel.RemoveFromParent();
            _currentPanel.Dispose();
            _currentPanel = null;
        }
        _currentPanelFullscreen = false;
        _currentPanelFitToScreen = IsLoginPackage(pkg);

        GObject view = UIPackage.CreateObject(pkg, comp);
        if (view == null)
        {
            Debug.LogError($"[FguiBootstrap] CreateObject failed. packageName={pkg}, componentName={comp}");
            return;
        }

        GRoot.inst.AddChild(view);
        _currentPanel = view;

        // 新的 UI_1 Login 包使用相对缩放（屏幕尺寸的 35%），适配不同分辨率
        if (string.Equals(pkg, "Login", StringComparison.OrdinalIgnoreCase))
        {
            _currentPanelScaleMultiplier = 0.35f; // 缩放到屏幕的 35%
            FitToScreenWithScale(view, _currentPanelScaleMultiplier);
        }
        else if (_currentPanelFitToScreen)
        {
            _currentPanelScaleMultiplier = 1.0f;
            FitToScreen(view);
        }
        else
        {
            _currentPanelScaleMultiplier = 1.0f;
            CenterPanel(view);
        }
    }

    private static void CenterPanel(GObject view)
    {
        if (view == null)
            return;

        view.SetPivot(0.5f, 0.5f);
        view.x = GRoot.inst.width * 0.5f;
        view.y = GRoot.inst.height * 0.5f;
    }

    private static void ScaleAndCenterPanel(GObject view, float scale)
    {
        if (view == null)
            return;

        view.scaleX = scale;
        view.scaleY = scale;
        view.SetPivot(0.5f, 0.5f);
        view.x = GRoot.inst.width * 0.5f;
        view.y = GRoot.inst.height * 0.5f;
    }

    private static void BindServerSelectHandlers()
    {
        if (!(_currentPanel is GComponent panel))
            return;

        // From UI skin XML: DBtnInGame -> proceed
        GObject inGame = panel.GetChild("DBtnInGame");
        if (inGame != null)
        {
            inGame.onClick.Clear();
            inGame.onClick.Add(() =>
            {
                ShowPanelCentered("UILoading", "登录_LoginUI");
                BindLoginHandlers();
                Debug.Log("[FguiBootstrap] Switch: ServerSel -> 登录_LoginUI");
            });
        }
    }

    private static void BindLoginHandlers()
    {
        if (!(_currentPanel is GComponent panel))
            return;

        // Try old UI names first (登录_LoginUI.xml)
        GTextInput idInput = panel.GetChild("DEditAccount") as GTextInput;
        GTextInput pwdInput = panel.GetChild("DEditPasswd") as GTextInput;
        GObject loginBtn = panel.GetChild("DBtnLoginOK");
        GObject closeBtn = panel.GetChild("DBtnLoginUIClose");

        // New UI_1 (logint_ui.xml) uses generic names: n4=account, n5=password, n2=login button, n3=close button
        if (idInput == null) idInput = panel.GetChild("n4") as GTextInput;
        if (pwdInput == null) pwdInput = panel.GetChild("n5") as GTextInput;
        if (loginBtn == null) loginBtn = panel.GetChild("n2");
        if (closeBtn == null) closeBtn = panel.GetChild("n3");

        // 自动填充上次的账号和密码
        if (idInput != null && !string.IsNullOrEmpty(Settings.AccountID))
            idInput.text = Settings.AccountID;
        if (pwdInput != null && !string.IsNullOrEmpty(Settings.Password))
            pwdInput.text = Settings.Password;

        // 自动恢复上次选择的区服（服务器列表已加载时才能匹配）
        if (_selectedServer == null && Settings.LastServerID > 0 && _serverConfig != null)
        {
            foreach (var region in _serverConfig.Regions)
                foreach (var srv in region.Servers)
                    if (srv.ServerID == Settings.LastServerID)
                    { _selectedServer = srv; break; }
        }

        if (loginBtn != null)
        {
            loginBtn.onClick.Clear();
            loginBtn.onClick.Add(() =>
            {
                string account = idInput?.text ?? string.Empty;
                string password = pwdInput?.text ?? string.Empty;

                if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
                {
                    ShowDialog("请输入账号和密码");
                    return;
                }

                if (_selectedServer == null)
                {
                    ShowDialog("请先选择区服");
                    return;
                }

                // 持久化账号密码
                Settings.AccountID = account;
                Settings.Password = password;
                Settings.Save();

                Net.Enqueue(new C.Login { AccountID = account, Password = password, ServerID = _selectedServer?.ServerID ?? 0 });
                Debug.Log($"[FguiBootstrap] Login clicked. AccountID={account}, ServerID={_selectedServer?.ServerID ?? 0}");
                ShowToast("正在登录...");
            });
        }

        if (closeBtn != null)
        {
            closeBtn.onClick.Clear();
            closeBtn.onClick.Add(() =>
            {
                Debug.Log("[FguiBootstrap] Close button clicked");
                Application.Quit();
            });
        }

        GObject registrationBtn = panel.GetChild("Registration");
        if (registrationBtn != null)
        {
            registrationBtn.onClick.Clear();
            registrationBtn.onClick.Add(() => ShowRegisterUI());
        }

        GObject electoralBtn = panel.GetChild("Electoral_district");
        if (electoralBtn != null)
        {
            // 显示上次选择的区服名（优先用当前已选，其次用保存的记录）
            if (_selectedServer != null)
                electoralBtn.text = _selectedServer.ServerName;
            else if (!string.IsNullOrEmpty(Settings.LastServerName))
                electoralBtn.text = Settings.LastServerName;

            electoralBtn.onClick.Clear();
            electoralBtn.onClick.Add(() => ShowEnlistUI());
        }

        Debug.Log($"[FguiBootstrap] Login handlers bound. idInput={idInput!=null}, pwdInput={pwdInput!=null}, loginBtn={loginBtn!=null}, closeBtn={closeBtn!=null}");
    }

    private System.Collections.IEnumerator DelayedDuplicateFix()
    {
        yield return null;
        DiagnoseAndFixDuplicateRendering();
        yield return null;
        DiagnoseAndFixDuplicateRendering();
    }

    private static void DiagnoseAndFixDuplicateRendering()
    {
        try
        {
            var bootstraps = UnityEngine.Object.FindObjectsOfType<FguiBootstrap>(true);
            Debug.Log($"[FguiBootstrap] Instances: {bootstraps.Length}");

            var stageCameras = UnityEngine.Object.FindObjectsOfType<FairyGUI.StageCamera>(true);
            Debug.Log($"[FguiBootstrap] StageCamera components: {stageCameras.Length}");

            int uiLayer = LayerMask.NameToLayer(FairyGUI.StageCamera.LayerName);
            if (uiLayer >= 0)
            {
                int uiMask = 1 << uiLayer;
                Camera[] cameras = UnityEngine.Object.FindObjectsOfType<Camera>(true);
                for (int i = 0; i < cameras.Length; i++)
                {
                    Camera cam = cameras[i];
                    if (cam == null)
                        continue;

                    // Keep StageCamera rendering UI, remove UI layer from all other cameras.
                    if (cam.GetComponent<FairyGUI.StageCamera>() != null)
                        continue;

                    if ((cam.cullingMask & uiMask) != 0)
                        cam.cullingMask &= ~uiMask;
                }
            }

            if (stageCameras.Length > 1)
            {
                for (int i = 1; i < stageCameras.Length; i++)
                {
                    var sc = stageCameras[i];
                    if (sc == null) continue;

                    var cam = sc.GetComponent<Camera>();
                    if (cam != null)
                        cam.enabled = false;

                    sc.enabled = false;
                }
                Debug.LogWarning("[FguiBootstrap] Multiple StageCameras detected; disabled extras to prevent double rendering.");
            }
        }
        catch (Exception ex)
        {
            Debug.LogException(ex);
        }
    }

    private static (string pkg, string comp) FindFirstLoginComponent()
    {
        UIPackage loadingPkg = UIPackage.GetByName("UILoading");
        if (loadingPkg != null)
        {
            try
            {
                List<PackageItem> items = loadingPkg.GetItems();
                for (int p = 0; p < PreferredLoginComponents.Length; p++)
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        var it = items[i];
                        if (it == null) continue;
                        if (!it.exported) continue;
                        if (it.type != PackageItemType.Component) continue;
                        if (string.Equals(it.name, PreferredLoginComponents[p], StringComparison.OrdinalIgnoreCase))
                            return ("UILoading", it.name);
                    }
                }
            }
            catch
            {
            }
        }

        int bestScore = int.MinValue;
        (string pkg, string comp) best = (null, null);

        foreach (string pkgName in DefaultPackageNames)
        {
            UIPackage pkg = UIPackage.GetByName(pkgName);
            if (pkg == null)
                continue;

            List<PackageItem> items;
            try
            {
                items = pkg.GetItems();
            }
            catch
            {
                continue;
            }

            for (int i = 0; i < items.Count; i++)
            {
                var it = items[i];
                if (it == null)
                    continue;

                if (!it.exported)
                    continue;

                if (it.type != PackageItemType.Component)
                    continue;

                string n = it.name ?? string.Empty;

                int score = ScoreLoginCandidate(pkgName, n);
                if (score > bestScore)
                {
                    bestScore = score;
                    best = (pkgName, n);
                }
            }
        }

        if (bestScore <= 0)
            return (null, null);

        return best;
    }

    private static int ScoreLoginCandidate(string pkgName, string component)
    {
        if (string.IsNullOrWhiteSpace(component))
            return 0;

        // Avoid tiny widgets
        if (component.IndexOf("button", StringComparison.OrdinalIgnoreCase) >= 0)
            return 0;

        // Avoid server-select by default; we'll show login first
        if (component.IndexOf("serversel", StringComparison.OrdinalIgnoreCase) >= 0)
            return 1;

        int score = 0;

        // Prefer likely login packages first
        if (pkgName.Equals("UILoading", StringComparison.OrdinalIgnoreCase)) score += 20;
        if (pkgName.Equals("UILoadingRes", StringComparison.OrdinalIgnoreCase)) score += 10;

        // Positive keywords
        for (int k = 0; k < LoginKeywords.Length; k++)
        {
            if (component.IndexOf(LoginKeywords[k], StringComparison.OrdinalIgnoreCase) >= 0)
                score += 10;
        }

        // Strong hints
        if (component.IndexOf("loginui", StringComparison.OrdinalIgnoreCase) >= 0) score += 30;
        if (component.IndexOf("scan", StringComparison.OrdinalIgnoreCase) >= 0) score += 10;
        if (component.IndexOf("real", StringComparison.OrdinalIgnoreCase) >= 0) score += 5;

        return score;
    }

    private static void LogLoginCandidates()
    {
        var candidates = new List<(int score, string pkg, string name)>();

        foreach (string pkgName in DefaultPackageNames)
        {
            UIPackage pkg = UIPackage.GetByName(pkgName);
            if (pkg == null)
                continue;

            try
            {
                List<PackageItem> items = pkg.GetItems();
                for (int i = 0; i < items.Count; i++)
                {
                    var it = items[i];
                    if (it == null)
                        continue;

                    if (!it.exported)
                        continue;

                    if (it.type != PackageItemType.Component)
                        continue;

                    string n = it.name ?? string.Empty;
                    int score = ScoreLoginCandidate(pkgName, n);
                    if (score > 0)
                        candidates.Add((score, pkgName, n));
                }
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
            }
        }

        if (candidates.Count == 0)
        {
            Debug.LogWarning("[FguiBootstrap] No login-related exported components found. Using fallback component.");
            return;
        }

        candidates.Sort((a, b) => b.score.CompareTo(a.score));
        int count = Math.Min(10, candidates.Count);
        var lines = new List<string>(count);
        for (int i = 0; i < count; i++)
            lines.Add($"  - ({candidates[i].score}) {candidates[i].pkg}/{candidates[i].name}");

        Debug.Log("[FguiBootstrap] Login candidates (top):\n" + string.Join("\n", lines));
    }

    private static void LogAllPackages()
    {
        try
        {
            Debug.Log("[FguiBootstrap] === All loaded packages ===");
            int count = UIPackage.GetPackages().Count;
            for (int i = 0; i < count; i++)
            {
                UIPackage pkg = UIPackage.GetPackages()[i];
                Debug.Log($"[FguiBootstrap]   Package #{i+1}: id={pkg.id}, name={pkg.name}, assetPath={pkg.assetPath}");
            }
            Debug.Log($"[FguiBootstrap] Total packages: {count}");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to list packages: {ex.Message}");
        }
    }

    private static void LogPackageComponents(string packageName)
    {
        try
        {
            UIPackage pkg = UIPackage.GetByName(packageName);
            if (pkg == null)
            {
                Debug.LogError($"[FguiBootstrap] Package not loaded: {packageName}");
                return;
            }

            List<PackageItem> items = pkg.GetItems();
            if (items == null)
            {
                Debug.LogWarning($"[FguiBootstrap] Package '{packageName}' has no items");
                return;
            }

            Debug.Log($"[FguiBootstrap] === Components in package '{packageName}' ===");
            int componentCount = 0;
            for (int i = 0; i < items.Count; i++)
            {
                var it = items[i];
                if (it == null) continue;
                if (!it.exported) continue;
                if (it.type != PackageItemType.Component) continue;

                componentCount++;
                Debug.Log($"[FguiBootstrap]   Component #{componentCount}: name='{it.name}', id={it.id}");
            }

            if (componentCount == 0)
            {
                Debug.LogWarning($"[FguiBootstrap] No exported components found in package '{packageName}'");
            }
            else
            {
                Debug.Log($"[FguiBootstrap] Total components: {componentCount}");
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to list components in package '{packageName}': {ex.Message}");
        }
    }

    private static string GetClassNameChinese(MirClass mirClass)
    {
        switch (mirClass)
        {
            case MirClass.Warrior:
                return "战士";
            case MirClass.Wizard:
                return "法师";
            case MirClass.Taoist:
                return "道士";
            default:
                return mirClass.ToString();
        }
    }

    private static void ShowCreateCharacterDialog()
    {
        try
        {
            Debug.Log("[FguiBootstrap] ShowCreateCharacterDialog called");

            // Check if already have 2 characters (maximum)
            if (_characters != null && _characters.Count >= 2)
            {
                ShowToast("最多只能创建2个角色");
                Debug.Log("[FguiBootstrap] Cannot create more characters - already have 2 characters");
                return;
            }

            // Use URL directly from UI_Create_characters.URL to avoid name conflicts
            string url = "ui://6zme3ysjkk2em";  // UI_Create_characters.URL

            GObject view = UIPackage.CreateObjectFromURL(url);

            if (view == null)
            {
                Debug.LogError("[FguiBootstrap] Failed to create Create_characters component from URL");
                ShowToast("无法打开创建人物界面");
                LogPackageComponents("Login");
                return;
            }

            Debug.Log($"[FguiBootstrap] Created object type: {view.GetType().Name} from URL: {url}");

            GComponent panel = view.asCom;
            if (panel == null)
            {
                Debug.LogError($"[FguiBootstrap] Component is not a GComponent. Type: {view.GetType().Name}");
                view.Dispose();
                return;
            }

            _createCharacter = panel;

            // Reset to default values
            _newCharClass = MirClass.Warrior;
            _newCharGender = MirGender.Male;

            // Add to root
            GRoot.inst.AddChild(_createCharacter);

            // Scale and center the dialog to fit screen better (similar to character select)
            FitToScreenWithScale(_createCharacter, 0.8f);  // Scale to 80% of screen size

            // Bind all buttons
            BindCreateCharacterDialog(panel);
            RefreshCreateCharacterDialog(panel);

            Debug.Log("[FguiBootstrap] Create character dialog shown");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to show create character dialog: {ex.Message}\n{ex.StackTrace}");
        }
    }

    private static void BindCreateCharacterDialog(GComponent panel)
    {
        try
        {
            // Bind class buttons (职业按钮)
            GObject zsBtn = panel.GetChild("zs");  // 战士
            if (zsBtn != null)
            {
                zsBtn.onClick.Clear();
                zsBtn.onClick.Add(() =>
                {
                    _newCharClass = MirClass.Warrior;
                    RefreshCreateCharacterDialog(panel);
                });
            }

            GObject fsBtn = panel.GetChild("fs");  // 法师
            if (fsBtn != null)
            {
                fsBtn.onClick.Clear();
                fsBtn.onClick.Add(() =>
                {
                    _newCharClass = MirClass.Wizard;
                    RefreshCreateCharacterDialog(panel);
                });
            }

            GObject dsBtn = panel.GetChild("ds");  // 道士
            if (dsBtn != null)
            {
                dsBtn.onClick.Clear();
                dsBtn.onClick.Add(() =>
                {
                    _newCharClass = MirClass.Taoist;
                    RefreshCreateCharacterDialog(panel);
                });
            }

            // Bind gender buttons (性别按钮)
            GObject manBtn = panel.GetChild("Man");  // 男
            if (manBtn != null)
            {
                manBtn.onClick.Clear();
                manBtn.onClick.Add(() =>
                {
                    _newCharGender = MirGender.Male;
                    RefreshCreateCharacterDialog(panel);
                });
            }

            GObject womanBtn = panel.GetChild("Woman");  // 女
            if (womanBtn != null)
            {
                womanBtn.onClick.Clear();
                womanBtn.onClick.Add(() =>
                {
                    _newCharGender = MirGender.Female;
                    RefreshCreateCharacterDialog(panel);
                });
            }

            // Bind Completed button (完成按钮)
            GObject completedBtn = panel.GetChild("Completed");
            if (completedBtn != null)
            {
                completedBtn.onClick.Clear();
                completedBtn.onClick.Add(() =>
                {
                    CreateNewCharacter(panel);
                });
            }

            // Bind Shut_down button (关闭按钮)
            GObject shutdownBtn = panel.GetChild("Shut_down");
            if (shutdownBtn != null)
            {
                shutdownBtn.onClick.Clear();
                shutdownBtn.onClick.Add(() =>
                {
                    CloseCreateCharacterDialog();
                });
            }

            Debug.Log("[FguiBootstrap] Create character dialog buttons bound");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to bind create character dialog: {ex.Message}");
        }
    }

    private static void RefreshCreateCharacterDialog(GComponent panel)
    {
        try
        {
            // Load character portrait based on selected class and gender
            GLoader portraitLoader = panel.GetChild("n10")?.asLoader;
            if (portraitLoader != null)
            {
                string classPrefix = _newCharClass == MirClass.Warrior ? "ws" :
                                    _newCharClass == MirClass.Wizard ? "fs" : "ds";
                string genderSuffix = _newCharGender == MirGender.Male ? "1" : "2";
                string portraitName = $"{classPrefix}_{genderSuffix}";

                string url = UIPackage.GetItemURL("Login", portraitName);
                if (!string.IsNullOrEmpty(url))
                {
                    portraitLoader.url = url;
                    Debug.Log($"[FguiBootstrap] Loaded create character portrait: {portraitName}");
                }
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to refresh create character dialog: {ex.Message}");
        }
    }

    private static void CreateNewCharacter(GComponent panel)
    {
        try
        {
            // Get name from input field
            GObject nameField = panel.GetChild("name");
            string characterName = "";

            if (nameField is GTextField tf)
                characterName = tf.text;
            else if (nameField is GTextInput ti)
                characterName = ti.text;

            // Validate name
            if (string.IsNullOrWhiteSpace(characterName))
            {
                ShowDialog("请输入角色名字");
                return;
            }

            if (characterName.Length < 2 || characterName.Length > 15)
            {
                ShowDialog("角色名字长度应为2-15个字符");
                return;
            }

            // Send NewCharacter packet to server
            Net.Enqueue(new C.NewCharacter
            {
                Name = characterName,
                Class = _newCharClass,
                Gender = _newCharGender,
                ServerID = _selectedServer?.ServerID ?? 0
            });

            ShowToast($"正在创建角色: {characterName}");
            Debug.Log($"[FguiBootstrap] Creating character: Name={characterName}, Class={_newCharClass}, Gender={_newCharGender}");

            // Close the dialog
            CloseCreateCharacterDialog();
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to create new character: {ex.Message}");
            ShowDialog("创建角色失败");
        }
    }

    private static void CloseCreateCharacterDialog()
    {
        try
        {
            if (_createCharacter != null)
            {
                _createCharacter.RemoveFromParent();
                _createCharacter.Dispose();
                _createCharacter = null;
                Debug.Log("[FguiBootstrap] Create character dialog closed");
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to close create character dialog: {ex.Message}");
        }
    }

    private static void DeleteCharacter()
    {
        try
        {
            // 检查是否有角色和是否选中了角色
            if (_characters == null || _characters.Count == 0)
            {
                ShowToast("没有角色可删除");
                Debug.Log("[FguiBootstrap] No characters to delete");
                return;
            }

            if (_selectedCharacterIndex < 0 || _selectedCharacterIndex >= _characters.Count)
            {
                ShowToast("请先选择要删除的角色");
                Debug.Log("[FguiBootstrap] No character selected");
                return;
            }

            SelectInfo selectedChar = _characters[_selectedCharacterIndex];

            // 使用 Common 包的 Dialog_box_z 对话框
            Common.UI_Dialog_box_z dialog = Common.UI_Dialog_box_z.CreateInstance();

            // 设置对话框消息文本 (n5 是文本框，index 3)
            GTextField messageText = dialog.GetChildAt(3) as GTextField;
            if (messageText != null)
            {
                messageText.text = $"确定要删除角色\n'{selectedChar.Name}' 吗？";
            }

            // 绑定 YES 按钮 - 直接删除
            dialog.m_yes.onClick.Clear();
            dialog.m_yes.onClick.Add(() =>
            {
                // 发送删除请求
                Debug.Log($"[FguiBootstrap] Deleting character: {selectedChar.Name} (Index={selectedChar.Index})");
                Net.Enqueue(new C.DeleteCharacter { CharacterIndex = selectedChar.Index });
                ShowToast($"正在删除角色: {selectedChar.Name}");

                // 关闭对话框
                dialog.RemoveFromParent();
                dialog.Dispose();
            });

            // 绑定 NO 按钮 - 取消删除
            dialog.m_no.onClick.Clear();
            dialog.m_no.onClick.Add(() =>
            {
                // 关闭对话框
                dialog.RemoveFromParent();
                dialog.Dispose();
            });

            // 显示对话框 - 居中
            GRoot.inst.AddChild(dialog);
            dialog.SetXY((GRoot.inst.width - dialog.width) / 2, (GRoot.inst.height - dialog.height) / 2);

            Debug.Log($"[FguiBootstrap] Showing delete confirmation for character: {selectedChar.Name}");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to delete character: {ex.Message}\n{ex.StackTrace}");
            ShowToast("删除角色失败");
        }
    }

    /// <summary>
    /// 显示选区界面（游戏启动时调用）
    /// </summary>
    public static void ShowPrefectureUI()
    {
        try
        {
            Debug.Log("[FguiBootstrap] ShowPrefectureUI called");

            // 移除当前面板
            _currentPanel?.RemoveFromParent();
            _currentPanel?.Dispose();
            _currentPanel = null;

            // 使用生成的 CreateInstance 方法创建选区界面
            Select.UI_Prefecture prefecture = Select.UI_Prefecture.CreateInstance();
            if (prefecture == null)
            {
                Debug.LogError("[FguiBootstrap] Failed to create Prefecture UI");
                ShowToast("选区界面加载失败");
                return;
            }

            _currentPanel = prefecture;
            GRoot.inst.AddChild(_currentPanel);

            // Prefecture 是 500x400，放大 2 倍到 1000x800 以便看清
            float scale = 3.0f;
            ScaleAndCenterPanel(_currentPanel, scale);

            Debug.Log($"[FguiBootstrap] Prefecture UI created, size: {prefecture.width}x{prefecture.height}, scaled: {scale}x");

            // 如果已选服务器，在按钮上显示服务器名
            if (_selectedServer != null)
            {
                prefecture.m_Electoral_district.title = _selectedServer.ServerName;
            }

            // 绑定按钮事件
            prefecture.m_Electoral_district.onClick.Clear();
            prefecture.m_Electoral_district.onClick.Add(() =>
            {
                Debug.Log("[FguiBootstrap] Electoral_district button clicked");
                ShowEnlistUI();
            });

            prefecture.m_Enter_the_game.onClick.Clear();
            prefecture.m_Enter_the_game.onClick.Add(() =>
            {
                Debug.Log("[FguiBootstrap] Enter_the_game button clicked");
                ShowLoginUI();
            });

            Debug.Log("[FguiBootstrap] Prefecture handlers bound");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to show Prefecture UI: {ex.Message}\n{ex.StackTrace}");
            ShowToast("选区界面显示失败");
        }
    }

    /// <summary>
    /// 点击选服按钮时列表尚未就绪：重新拉取，成功后自动打开选服界面。
    /// </summary>
    private static IEnumerator FetchThenOpenEnlistCoroutine()
    {
        yield return _instance.StartCoroutine(FetchServerListCoroutine());
        if (_serverConfig != null)
            ShowEnlistUI();
        else
            ShowToast("无法获取区服列表，请检查网络或联系管理员");
    }

    /// <summary>
    /// 后台协程：从列表服务器拉取区服列表。
    /// 拉取失败则保持 _serverConfig = null，打开选服界面时再提示用户。
    /// </summary>
    private static IEnumerator FetchServerListCoroutine()
    {
        // 从 cfg.ini [HotUpdate] BaseUrl 拼接，与热更新用同一个 HTTP 服务
        string url = Settings.HotUpdateBaseUrl + "serverlist.json";
        Debug.Log($"[FguiBootstrap] Fetching server list from: {url}");

        using (UnityWebRequest req = UnityWebRequest.Get(url))
        {
            req.timeout = 5;
            yield return req.SendWebRequest();

            if (req.result == UnityWebRequest.Result.Success)
            {
                try
                {
                    _serverConfig = JsonUtility.FromJson<ServerConfig>(req.downloadHandler.text);
                    Debug.Log($"[FguiBootstrap] Server list fetched OK: {_serverConfig.Regions.Count} regions");
                }
                catch (Exception ex)
                {
                    Debug.LogWarning($"[FguiBootstrap] Server list parse error: {ex.Message}");
                    _serverConfig = null;
                }
            }
            else
            {
                Debug.LogWarning($"[FguiBootstrap] Server list fetch failed: {req.error}");
                _serverConfig = null;
            }
        }
    }

    /// <summary>
    /// 显示选服界面（点击 Electoral_district 后调用）
    /// </summary>
    private static void ShowEnlistUI()
    {
        try
        {
            Debug.Log("[FguiBootstrap] ShowEnlistUI called");

            // 列表未就绪：现场重新拉取，拉到后自动打开
            if (_serverConfig == null)
            {
                ShowToast("正在获取区服列表...");
                _instance?.StartCoroutine(FetchThenOpenEnlistCoroutine());
                return;
            }

            // 移除当前面板
            _currentPanel?.RemoveFromParent();
            _currentPanel?.Dispose();
            _currentPanel = null;

            // 直接使用 URL 创建选服界面（避免名称冲突：Enlist.png 和 Enlist.xml）
            string enlistURL = Select.UI_Enlist.URL;  // "ui://2q0aw32tldap1"
            GObject obj = UIPackage.CreateObjectFromURL(enlistURL);
            if (obj == null)
            {
                Debug.LogError($"[FguiBootstrap] Failed to create Enlist UI from URL: {enlistURL}");
                ShowToast("选服界面加载失败");
                return;
            }

            Select.UI_Enlist enlist = obj as Select.UI_Enlist;
            if (enlist == null)
            {
                Debug.LogError($"[FguiBootstrap] Created object is not UI_Enlist, type: {obj.GetType().Name}");
                obj.Dispose();
                ShowToast("选服界面类型错误");
                return;
            }

            _currentPanel = enlist;
            GRoot.inst.AddChild(_currentPanel);
            FitCharacterSelectToScreen(enlist);

            Debug.Log($"[FguiBootstrap] Enlist UI created, size: {enlist.width}x{enlist.height}");

            // 填充测试服务器数据
            BindEnlistHandlers(enlist);
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to show Enlist UI: {ex.Message}\n{ex.StackTrace}");
            ShowToast("选服界面显示失败");
        }
    }

    /// <summary>
    /// 绑定选服界面的事件
    /// </summary>
    private static void BindEnlistHandlers(Select.UI_Enlist enlist)
    {
        try
        {
            if (_serverConfig == null || _serverConfig.Regions.Count == 0)
            {
                Debug.LogError("[FguiBootstrap] Server config is empty");
                ShowToast("服务器配置加载失败");
                return;
            }

            // 默认选择第一个大区
            int selectedRegionIndex = 0;

            // 填充大区列表
            if (enlist.m_Region != null)
            {
                enlist.m_Region.RemoveChildrenToPool();

                for (int i = 0; i < _serverConfig.Regions.Count; i++)
                {
                    RegionInfo region = _serverConfig.Regions[i];
                    GButton regionItem = enlist.m_Region.AddItemFromPool()?.asButton;
                    if (regionItem != null)
                    {
                        regionItem.title = region.RegionName;
                        int regionIndex = i;
                        regionItem.onClick.Clear();
                        regionItem.onClick.Add(() =>
                        {
                            Debug.Log($"[FguiBootstrap] Region selected: {region.RegionName}");
                            selectedRegionIndex = regionIndex;
                            // 刷新服务器列表
                            RefreshServerList(enlist, regionIndex);
                        });
                    }
                }
                Debug.Log($"[FguiBootstrap] Region list populated with {_serverConfig.Regions.Count} items");
            }

            // 初始显示第一个大区的服务器列表
            RefreshServerList(enlist, selectedRegionIndex);
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to bind Enlist handlers: {ex.Message}\n{ex.StackTrace}");
        }
    }

    /// <summary>
    /// 刷新服务器列表
    /// </summary>
    private static void RefreshServerList(Select.UI_Enlist enlist, int regionIndex)
    {
        try
        {
            if (enlist.m_Neighborhood == null) return;

            enlist.m_Neighborhood.RemoveChildrenToPool();

            if (regionIndex < 0 || regionIndex >= _serverConfig.Regions.Count)
            {
                Debug.LogError($"[FguiBootstrap] Invalid region index: {regionIndex}");
                return;
            }

            RegionInfo region = _serverConfig.Regions[regionIndex];
            Debug.Log($"[FguiBootstrap] Refreshing server list for region: {region.RegionName}");

            for (int i = 0; i < region.Servers.Count; i++)
            {
                ServerInfo server = region.Servers[i];
                GButton serverItem = enlist.m_Neighborhood.AddItemFromPool()?.asButton;
                if (serverItem != null)
                {
                    // 设置服务器显示名称（带状态）
                    string displayName = $"{server.GetDisplayName()} [{server.GetStatusText()}]";
                    serverItem.title = displayName;

                    // 根据状态设置颜色
                    // serverItem.GetChild("title")?.asTextField?.color = GetStatusColor(server.Status);

                    serverItem.onClick.Clear();
                    serverItem.onClick.Add(() =>
                    {
                        // 维护中的服务器不能选择
                        if (server.Status == ServerStatus.Maintenance)
                        {
                            ShowToast("该服务器维护中，请选择其他服务器");
                            return;
                        }

                        // 爆满的服务器提示
                        if (server.Status == ServerStatus.Full)
                        {
                            ShowToast("该服务器人数已满，可能无法进入");
                        }

                        _selectedServer = server;
                        Settings.LastServerID = server.ServerID;
                        Settings.LastServerName = server.ServerName;
                        Settings.Save();
                        Debug.Log($"[FguiBootstrap] Server selected: {server.ServerName} (ID={server.ServerID})");

                        // 选择服务器后回到登录界面
                        ShowLoginUI();
                    });
                }
            }

            Debug.Log($"[FguiBootstrap] Server list populated with {region.Servers.Count} servers");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to refresh server list: {ex.Message}\n{ex.StackTrace}");
        }
    }

    /// <summary>
    /// 显示注册界面
    /// </summary>
    public static void ShowRegisterUI()
    {
        try
        {
            _currentPanel?.RemoveFromParent();
            _currentPanel?.Dispose();
            _currentPanel = null;

            if (_background != null)
                _background.visible = true;

            GObject obj = UIPackage.CreateObjectFromURL(Login.UI_Register_account.URL);
            if (obj == null)
            {
                Debug.LogError("[FguiBootstrap] Failed to create Register_account UI");
                ShowToast("注册界面加载失败");
                return;
            }

            Login.UI_Register_account register = obj as Login.UI_Register_account;
            if (register == null)
            {
                Debug.LogError($"[FguiBootstrap] Register_account cast failed, type: {obj.GetType().Name}");
                obj.Dispose();
                ShowToast("注册界面加载失败");
                return;
            }

            _currentPanel = register;
            GRoot.inst.AddChild(_currentPanel);
            _currentPanelScaleMultiplier = 0.35f;
            FitToScreenWithScale(register, _currentPanelScaleMultiplier);

            BindRegisterHandlers(register);
            Debug.Log("[FguiBootstrap] Register UI shown");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to show Register UI: {ex.Message}\n{ex.StackTrace}");
            ShowToast("注册界面显示失败");
        }
    }

    private static void BindRegisterHandlers(Login.UI_Register_account register)
    {
        register.m_return_Button.onClick.Clear();
        register.m_return_Button.onClick.Add(() => ShowLoginUI());

        register.m_Register_Button.onClick.Clear();
        register.m_Register_Button.onClick.Add(() =>
        {
            string account = register.m_Account?.text ?? string.Empty;
            string password = register.m_Password?.text ?? string.Empty;
            string confirm = register.m_Password_1?.text ?? string.Empty;

            if (string.IsNullOrEmpty(account))
            {
                ShowToast("请输入账号");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                ShowToast("请输入密码");
                return;
            }
            if (password != confirm)
            {
                ShowToast("两次密码输入不一致");
                return;
            }

            Net.Enqueue(new C.NewAccount
            {
                AccountID = account,
                Password = password,
                UserName = account,
                BirthDate = new DateTime(1990, 1, 1),
                SecretQuestion = string.Empty,
                SecretAnswer = string.Empty,
                EMailAddress = string.Empty
            });

            ShowToast("正在注册...");
            Debug.Log($"[FguiBootstrap] Register clicked. AccountID={account}");
        });
    }

    /// <summary>
    /// 显示登录界面
    /// </summary>
    public static void ShowLoginUI()
    {
        try
        {
            if (_selectedServer != null)
            {
                Debug.Log($"[FguiBootstrap] ShowLoginUI called, selected server: {_selectedServer.ServerName} (ID={_selectedServer.ServerID})");
            }
            else
            {
                Debug.Log("[FguiBootstrap] ShowLoginUI called, no server selected (Enter_the_game clicked)");
            }

            // 移除当前面板
            _currentPanel?.RemoveFromParent();
            _currentPanel?.Dispose();
            _currentPanel = null;

            // 显示登录背景
            if (_background != null)
                _background.visible = true;

            // 显示登录界面
            ShowPanelCentered("Login", "logint_ui");
            BindLoginHandlers();

            // 连接地址由 cfg.ini 控制（IPAddress/Port），直接连
            if (!Net.Connected)
            {
                Net.Connect();
                Debug.Log("[FguiBootstrap] Connecting to server...");
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"[FguiBootstrap] Failed to show Login UI: {ex.Message}\n{ex.StackTrace}");
            ShowToast("登录界面显示失败");
        }
    }
}

}
