using System;
using System.Collections.Generic;
using FairyGUI;
using UnityEngine;
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

            // UI_1 only - no legacy UI packages needed

            (string pkg, string comp) selected = FindFirstLoginComponent();
            if (!string.IsNullOrEmpty(selected.pkg) && !string.IsNullOrEmpty(selected.comp))
            {
                packageName = selected.pkg;
                componentName = selected.comp;
            }

            LogLoginCandidates();

            // Debug: List all loaded packages
            LogAllPackages();

            // Debug: List all components in Login package
            LogPackageComponents("Login");

            if (GRoot.inst != null)
                GRoot.inst.RemoveChildren(0, -1, true);

            CreateBackground();

            // Ensure network begins connecting even without legacy LoginScene.
            MirScene.ActiveScene = new FguiBridgeScene();
            Net.Connect();

            // Entry screen: directly show new login UI from UI_1
            ShowPanelCentered(firstPanelPackage, firstPanelComponent);
            BindLoginHandlers();

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
                // New UI_1 layout (uses GTextInput fields)
                SetText("name_1", currentChar?.Name);
                SetText("Level_1", currentChar != null ? $"Lv.{currentChar.Level}" : string.Empty);
                SetText("Occupation_1", currentChar != null ? currentChar.Class.ToString() : string.Empty);

                // 显示性别
                if (genderField != null && currentChar != null)
                {
                    string genderText = currentChar.Gender == MirGender.Male ? "男" : "女";
                    SetText("Gender_1", genderText);
                }

                // 加载角色肖像
                LoadCharacterPortrait(panel, currentChar);

                Debug.Log($"[FguiBootstrap] Character select refreshed (UI_1): {currentChar?.Name} Lv.{currentChar?.Level} {currentChar?.Class} {currentChar?.Gender}");
            }
            else
            {
                // Old UI layout (two characters side by side)
                SelectInfo c1 = _characters != null && _characters.Count > 0 ? _characters[0] : null;
                SelectInfo c2 = _characters != null && _characters.Count > 1 ? _characters[1] : null;

                SetText("DName1", c1?.Name);
                SetText("DLevel1", c1 != null ? $"Lv.{c1.Level}" : string.Empty);
                SetText("DJob1", c1 != null ? c1.Class.ToString() : string.Empty);

                SetText("DName2", c2?.Name);
                SetText("DLevel2", c2 != null ? $"Lv.{c2.Level}" : string.Empty);
                SetText("DJob2", c2 != null ? c2.Class.ToString() : string.Empty);

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

            GTextField rowText = new GTextField { text = $"{ch.Name}   Lv.{ch.Level}   {ch.Class}" };
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

        if (loginBtn != null)
        {
            loginBtn.onClick.Clear();
            loginBtn.onClick.Add(() =>
            {
                string account = idInput?.text ?? string.Empty;
                string password = pwdInput?.text ?? string.Empty;

                if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
                {
                    ShowToast("请输入账号和密码");
                    return;
                }

                // Persist to Settings
                Settings.AccountID = account;
                Settings.Password = password;

                Net.Enqueue(new C.Login { AccountID = account, Password = password });
                Debug.Log($"[FguiBootstrap] Login clicked. AccountID={account}");
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
}

}
