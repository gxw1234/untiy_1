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
    private static GComponent _characterSelect;
    private static bool _characterSelectIsPackagedUI;
    private static GGraph _characterSelectBackdrop;
    private static List<SelectInfo> _characters;
    private static int _selectedCharacterIndex;

    [SerializeField] private string packageName = "UILoading";
    [SerializeField] private string componentName = "PC登录_LoginUI";

    [SerializeField] private string firstPanelPackage = "UILoading";
    [SerializeField] private string firstPanelComponent = "选服_DServerSelUI";

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
        "PC登录_LoginUI",
        "PC登录2_LoginUI2",
        "登录_LoginUI",
    };

    private static readonly string[] DefaultPackagePaths =
    {
        "UI/BaseRes",
        "UI/Font",
        "UI/Sounds",
        "UI/UILoadingRes",
        "UI/UILoading",
        "UI/UIRes",
        "UI/UI",
        "UI/FormId",
        "UI/自定义组件",
    };

    private static readonly string[] DefaultPackageNames =
    {
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
                }
                catch (Exception)
                {
                    // ignore: package may not exist in Resources
                }
            }

            (string pkg, string comp) selected = FindFirstLoginComponent();
            if (!string.IsNullOrEmpty(selected.pkg) && !string.IsNullOrEmpty(selected.comp))
            {
                packageName = selected.pkg;
                componentName = selected.comp;
            }

            LogLoginCandidates();

            if (GRoot.inst != null)
                GRoot.inst.RemoveChildren(0, -1, true);

            CreateBackground();

            // Ensure network begins connecting even without legacy LoginScene.
            MirScene.ActiveScene = new FguiBridgeScene();
            Net.Connect();

            ShowPanelCentered(firstPanelPackage, firstPanelComponent);
            BindServerSelectHandlers();

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
        _characters = characters ?? new List<SelectInfo>();
        _selectedCharacterIndex = 0;

        if (_background != null)
            _background.visible = false;

        _characterSelectIsPackagedUI = false;

        EnsureCharacterSelectBackdrop();

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
            _characterSelect = BuildCharacterSelectPanel();
            GRoot.inst.AddChild(_characterSelect);
            CenterPanel(_characterSelect);
        }
    }

    private static bool TryShowFairyGuiCharacterSelect()
    {
        try
        {
            // This component exists in both retro/micro skin sources. Runtime packages may differ,
            // so we probe by creating it.
            GObject view = UIPackage.CreateObject("UI", "选角_CharSelectUI");
            if (view == null)
                return false;

            GComponent panel = view.asCom;
            if (panel == null)
            {
                view.Dispose();
                return false;
            }

            _characterSelect = panel;
            _characterSelectIsPackagedUI = true;

            EnsureCharacterSelectBackdrop();
            GRoot.inst.AddChild(_characterSelect);
            FitCharacterSelectToScreen(_characterSelect);

            BindFairyGuiCharacterSelect(panel);
            RefreshFairyGuiCharacterSelect(panel);
            return true;
        }
        catch
        {
            return false;
        }
    }

    private static void BindFairyGuiCharacterSelect(GComponent panel)
    {
        try
        {
            GButton start = panel.GetChild("DStart")?.asButton;
            if (start != null)
            {
                start.onClick.Clear();
                start.onClick.Add(() =>
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
            }

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
        catch
        {
        }
    }

    private static void RefreshFairyGuiCharacterSelect(GComponent panel)
    {
        try
        {
            void SetText(string childName, string value)
            {
                GTextField tf = panel.GetChild(childName)?.asTextField;
                if (tf != null)
                    tf.text = value ?? string.Empty;
            }

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
        catch
        {
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

        // Fullscreen background from UILoadingRes package.
        // Note: resource name is inferred from candidates list; adjust if you want another.
        string url = UIPackage.GetItemURL("UILoadingRes", "DLoginBg");
        if (string.IsNullOrEmpty(url))
            return;

        _background = new GLoader
        {
            url = url,
            fill = FillType.Scale,
            align = AlignType.Center,
            verticalAlign = VertAlignType.Middle,
            touchable = false
        };

        GRoot.inst.AddChild(_background);
        _background.SetSize(GRoot.inst.width, GRoot.inst.height);
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
            else
                CenterPanel(_currentPanel);
        }
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

        GObject view = UIPackage.CreateObject(pkg, comp);
        if (view == null)
        {
            Debug.LogError($"[FguiBootstrap] CreateObject failed. packageName={pkg}, componentName={comp}");
            return;
        }

        GRoot.inst.AddChild(view);
        _currentPanel = view;
        CenterPanel(view);
    }

    private static void CenterPanel(GObject view)
    {
        if (view == null)
            return;

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
                ShowPanelCentered("UILoading", "PC登录_LoginUI");
                BindLoginHandlers();
                Debug.Log("[FguiBootstrap] Switch: ServerSel -> PC登录_LoginUI");
            });
        }
    }

    private static void BindLoginHandlers()
    {
        if (!(_currentPanel is GComponent panel))
            return;

        // Input fields from UI skin XML
        GTextInput idInput = panel.GetChild("UserIDInput") as GTextInput;
        GTextInput pwdInput = panel.GetChild("UserPasswordInput") as GTextInput;

        // Buttons from UI skin XML
        GObject loginBtn = panel.GetChild("LoginButton");
        GObject registerBtn = panel.GetChild("RegisterButton");
        GObject resetBtn = panel.GetChild("ResetPassword");
        GObject phoneBtn = panel.GetChild("PhoneLogin");
        GObject scanBtn = panel.GetChild("ScanLoginButton");

        if (loginBtn != null)
        {
            loginBtn.onClick.Clear();
            loginBtn.onClick.Add(() =>
            {
                string account = idInput?.text ?? string.Empty;
                string password = pwdInput?.text ?? string.Empty;

                // Persist to Settings (optional)
                Settings.AccountID = account;
                Settings.Password = password;

                Net.Enqueue(new C.Login { AccountID = account, Password = password });
                Debug.Log($"[FguiBootstrap] LoginButton clicked. AccountID={account}");
            });
        }

        if (registerBtn != null)
        {
            registerBtn.onClick.Clear();
            registerBtn.onClick.Add(() =>
            {
                ShowPanelCentered("UILoading", "PC注册_Register");
                Debug.Log("[FguiBootstrap] RegisterButton clicked.");
            });
        }

        if (resetBtn != null)
        {
            resetBtn.onClick.Clear();
            resetBtn.onClick.Add(() =>
            {
                ShowPanelCentered("UILoading", "PC重置密码_ResetPassword");
                Debug.Log("[FguiBootstrap] ResetPassword clicked.");
            });
        }

        if (phoneBtn != null)
        {
            phoneBtn.onClick.Clear();
            phoneBtn.onClick.Add(() =>
            {
                ShowPanelCentered("UILoading", "PC登录2_LoginUI2");
                Debug.Log("[FguiBootstrap] PhoneLogin clicked.");
            });
        }

        if (scanBtn != null)
        {
            scanBtn.onClick.Clear();
            scanBtn.onClick.Add(() =>
            {
                ShowPanelCentered("UILoading", "PC扫码登录_ScanLogin");
                Debug.Log("[FguiBootstrap] ScanLogin clicked.");
            });
        }

        Debug.Log("[FguiBootstrap] Login handlers bound.");
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
}

}
