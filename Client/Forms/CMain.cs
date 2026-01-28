using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Client.MirControls;
using Client.MirGraphics;
using NetWorkClinet = Client.MirNetwork.Network;
using Client.MirScenes;
using Client.MirSounds;
using Shared.Unity;
using UnityEngine;
using Font = Shared.Unity.Font;
using Unity.VisualScripting;
using System.Collections.Generic;
using System.Text;
using FairyGUI;
using static FairyGUI.UIContentScaler;
using System.Collections;

namespace Client
{
    public partial class CMain : MonoBehaviour
    {
        private static GUIStyle cachedStyle;

        public static Size GetTextSize(string text, Shared.Unity.Font font)
        {
            //参数一 ： text
            //参数二： font
            if (cachedStyle == null)
            {
                cachedStyle = new GUIStyle(CMain.style);
            }

            cachedStyle.fontSize = (int)font.Size;

            UnityEngine.GUIContent content = new UnityEngine.GUIContent(text);
            UnityEngine.Vector2 size = cachedStyle.CalcSize(content);
            return new Size((int)size.x, (int)size.y);
        }

        public static Size GetTextSize(string text, Size _size, Shared.Unity.Font font)
        {
            //参数一 ： text
            //参数二： size
            //参数三：font
            if (cachedStyle == null)
            {
                cachedStyle = new GUIStyle(CMain.style);
            }

            cachedStyle.fontSize = (int)font.Size;

            UnityEngine.GUIContent content = new UnityEngine.GUIContent(text);
            UnityEngine.Vector2 size = cachedStyle.CalcSize(content);
            int height = (size.x > _size.Width) ? (int)cachedStyle.CalcHeight(content, _size.Width) : (int)size.y;
            height = Mathf.Min(height, _size.Height);
            return new Size(Mathf.Min((int)size.x, _size.Width), height);
        }
        public static MirControl DebugBaseLabel, HintBaseLabel;
        public static MirLabel DebugTextLabel, HintTextLabel, ScreenshotTextLabel;
        public static Graphics Graphics;
        public static Point MPoint;
        public Camera StageCamera; 
        public readonly static Stopwatch Timer = Stopwatch.StartNew();
        public readonly static DateTime StartTime = DateTime.UtcNow;
        public static long Time;
        public static DateTime Now { get { return StartTime.AddMilliseconds(Time); } }
        public static readonly System.Random Random = new System.Random();

        public static string DebugText = "";

        private static long _fpsTime;
        private static int _fps;
        private static long _cleanTime;
        private static long _drawTime;
        public static int FPS;
        public static int DPS;
        public static int DPSCounter;

        public static long PingTime;
        public static long NextPing = 10000;

        public static bool Shift, Alt, Ctrl, Tilde, SpellTargetLock;
        public static double BytesSent, BytesReceived;

        //输入事件
        public static UnityEngine.Vector3 mousePosition;
        public static event MouseEventHandler MouseClick, MouseDown, MouseUp, MouseMove, MouseDoubleClick, Deactivate, MouseWheel;

        public static event KeyEventHandler KeyDown, KeyUp;
        public static event KeyPressEventHandler KeyPress;

        public static KeyBindSettings InputKeys;

        //文字
        public static UnityEngine.GUIStyle style;
        public static UnityEngine.GUIStyle style2;
        public static UnityEngine.Font fontA;
            private GProgressBar pb; 
            private GComponent view; 
    private double lastValue = -1;
        public CMain()
        {
            // InitializeComponent();

            // Application.Idle += Application_Idle;

            // MouseClick += CMain_MouseClick;
            // MouseDown += CMain_MouseDown;
            // MouseUp += CMain_MouseUp;
            // MouseMove += CMain_MouseMove;
            // MouseDoubleClick += CMain_MouseDoubleClick;
            // KeyPress += CMain_KeyPress;
            // KeyDown += CMain_KeyDown;
            // KeyUp += CMain_KeyUp;
            // Deactivate += CMain_Deactivate;
            // MouseWheel += CMain_MouseWheel;


            // SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.Selectable, true);
            // FormBorderStyle = Settings.FullScreen || Settings.Borderless ? FormBorderStyle.None : FormBorderStyle.FixedDialog;

            // Graphics = CreateGraphics();
            // Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            // Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            // Graphics.CompositingQuality = CompositingQuality.HighQuality;
            // Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            // Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            // Graphics.TextContrast = 0;
        }

        void Awake()
        {
            UnityEngine.Debug.Log(Settings.resRootPath);

            InputKeys = new KeyBindSettings();

            UpdateUISize();
            Settings.Load();
            DXManager.Create();
            SoundManager.Create();

            fontA = UnityEngine.Resources.Load<UnityEngine.Font>("fonts/hm");
            style = new UnityEngine.GUIStyle();
            style.font = fontA;

            style2 = new UnityEngine.GUIStyle();
            style2.font = fontA;
        }
        
        void Start()
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            Application.runInBackground = true; //后台运行
            Application.targetFrameRate = 90; //将最大帧率设置为90 fps

            MirObjectPool.Instance().CreateObjectPool(MirControlEnum.MirAudioSource, 1);
            

            MouseClick += CMain_MouseClick;
            MouseDown += CMain_MouseDown;
            MouseUp += CMain_MouseUp;
            MouseMove += CMain_MouseMove;
            MouseDoubleClick += CMain_MouseDoubleClick;
            KeyPress += CMain_KeyPress;
            KeyDown += CMain_KeyDown;
            KeyUp += CMain_KeyUp;
            Deactivate += CMain_Deactivate;
            MouseWheel += CMain_MouseWheel;
            //加载包
            UIPackage.AddPackage("UI/UILoading");
            UIPackage.AddPackage("UI/UILoadingRes");
            UIPackage.AddPackage("UI/UIRes");
            UIPackage.AddPackage("UI/UI");
            //动态创建ui
            view = UIPackage.CreateObject("UILoading", "进度条_ScheduleCopntUI").asCom;
            //自适应屏幕
            GRoot.inst.SetContentScaleFactor(1280,720,ScreenMatchMode.MatchHeight);
            view.x = (GRoot.inst.width - view.width)/2;
            //
            pb = view.GetChild("ScheduleProg").asProgress;
            pb.value = 0;   
    float animationDuration = 0.5f;  
    StartCoroutine(AnimateProgressBar(animationDuration)); 
            lastValue = pb.value;  
  
            // if(pb.value < 100)
            // {
            //      view.Dispose();
            // }
            //挂载
            GRoot.inst.AddChild(view);
            // //获取fgui渲染相机
            // if(GameObject.Find("Stage Camera")!=null)
            // {
            //     StageCamera = GameObject.Find("Stage Camera").GetComponent<Camera>();
            // }

        }
        
        private IEnumerator AnimateProgressBar(float duration)  
{  
    float startTime = UnityEngine.Time.time;  
    float targetValue = 100f;  
  
    while (pb.value < targetValue)  
    {  
        float elapsedTime = UnityEngine.Time.time - startTime;  
        float progress = elapsedTime / duration;  
        pb.value = Mathf.Clamp01(progress) * targetValue;  
  
        // 等待下一帧  
        yield return null;  
    }  
  
    // 确保值正好是100（由于浮点运算的精度问题，可能会有微小的差异）  
    pb.value = targetValue;  
  
    // 处理进度条完成后的逻辑  
    OnProgressBarComplete();  
}  
  
// 进度条完成后的处理  
private void OnProgressBarComplete()  
{  
    // 确保view已经被添加到GRoot中，并且现在不再需要它  
    if (view != null && GRoot.inst.GetChildIndex(view) != -1)  
    {  
        GRoot.inst.RemoveChild(view); // 从GRoot中移除view  
        view.Dispose(); // 释放view资源  
        view = null; // 将view设置为null，以避免潜在的空引用异常  
    }  
  
    // 在这里添加其他处理逻辑，如加载下一个场景等  
}

        void Update()
        {
            //获取fgui渲染相机
            if(GameObject.Find("Stage Camera")!=null)
            {
                StageCamera = GameObject.Find("Stage Camera").GetComponent<Camera>();
            }
            if (SystemInfo.operatingSystem.Contains("Windows"))
            {
                UpdateUISize();
            }

            UpdateTime();
            UpdateFrameTime();
            UpdateEnviroment();

#if UNITY_ANDROID
            HandleTouchInput();// 处理触摸输入
#elif UNITY_IOS
            HandleTouchInput();// 处理触摸输入
#else
            HandleMouseInput();// 处理鼠标输入
#endif
            HandheKeys(); //处理键盘输入
        }

        void OnRenderObject()
        {
            // GL.PushMatrix();

            // // 计算中心偏移
            // float offsetX = (1 - Settings.SizeRatio) * Screen.width / 2f;
            // float offsetY = (1 - Settings.SizeRatio) * Screen.height / 2f;

            // // 设置像素矩阵并应用缩放
            // GL.LoadPixelMatrix(0, Screen.width, Screen.height, 0);
            // Matrix4x4 pixelMatrix = Matrix4x4.TRS(new UnityEngine.Vector3(offsetX, offsetY, 0), Quaternion.identity, new UnityEngine.Vector3(Settings.SizeRatio, Settings.SizeRatio, 1f));
            // GL.MultMatrix(pixelMatrix);

            // // Texture2D newTexture = Libraries.ChrSel.GetTexture(20);
            // // Graphics.DrawTexture(new UnityEngine.Rect(0,0,newTexture.width,newTexture.height),newTexture);
            // if (IsDrawTime())
            //     RenderEnvironment();

            // GL.PopMatrix();
        }
        public static TextBox ProgramFormActiveControl = null;
        public static Dictionary<string,MirTextBox> ProgramForm1 = new Dictionary<string,MirTextBox>();
        public static string activatTextFieId = "";
        public static bool useTextFieId = false;
        public UnityEngine.TouchScreenKeyboard Keyboard;//虚拟键盘
        //输入框键盘输入窗口相关
        public static void AddTextFieldObject(string name,MirTextBox obj)
        {
            ProgramForm1.Add(name,obj);
        }

        public static void DelTextFieldObject(string name)
        {
            if(ProgramForm1.TryGetValue(name,out MirTextBox value))
            {
                ProgramForm1.Remove(name);
            }
        }

        void OnGUI()
        {
            if(Event.current.type == EventType.Repaint)
            {
                GL.PushMatrix();

            // 计算中心偏移
            float offsetX = (1 - Settings.SizeRatio) * Screen.width / 2f;
            float offsetY = (1 - Settings.SizeRatio) * Screen.height / 2f;

            // 设置像素矩阵并应用缩放
            GL.LoadPixelMatrix(0, Screen.width, Screen.height, 0);
            Matrix4x4 pixelMatrix = Matrix4x4.TRS(new UnityEngine.Vector3(offsetX, offsetY, 0), Quaternion.identity, new UnityEngine.Vector3(Settings.SizeRatio, Settings.SizeRatio, 1f));
            GL.MultMatrix(pixelMatrix);

            // Texture2D newTexture = Libraries.ChrSel.GetTexture(20);
            // Graphics.DrawTexture(new UnityEngine.Rect(0,0,newTexture.width,newTexture.height),newTexture);
            if (IsDrawTime())
                RenderEnvironment();

            GL.PopMatrix();
//最后读取相机
            if(StageCamera!=null)
            {
                StageCamera.Render();
            }
            
            }
            
            //输入框的绘制
            useTextFieId = false;
            foreach (var Kvp in ProgramForm1.ToList())
            {
                if(ProgramForm1[Kvp.Key].TextBox.Visible)
                {
                    GUILayout.BeginArea(new Rect(ProgramForm1[Kvp.Key].DisplayLocation.X,ProgramForm1[Kvp.Key].DisplayLocation.Y,ProgramForm1[Kvp.Key].Size.Width,ProgramForm1[Kvp.Key].Size.Height));
                    
                    GUI.SetNextControlName(Kvp.Key); 

                    //密码模式
                    if(ProgramForm1[Kvp.Key].Password)
                    {
                        ProgramForm1[Kvp.Key].Text = GUILayout.PasswordField(ProgramForm1[Kvp.Key].Text,'*',ProgramForm1[Kvp.Key].TextBox.MaxLength,ProgramForm1[Kvp.Key].style2,GUILayout.Width(ProgramForm1[Kvp.Key].Size.Width),GUILayout.Height(ProgramForm1[Kvp.Key].Size.Height));//支持中文
                        
                    }else{
                        //GUI.TextField();//不支持中文
                        ProgramForm1[Kvp.Key].Text = GUILayout.TextField(ProgramForm1[Kvp.Key].Text,ProgramForm1[Kvp.Key].TextBox.MaxLength,ProgramForm1[Kvp.Key].style2,GUILayout.Width(ProgramForm1[Kvp.Key].Size.Width),GUILayout.Height(ProgramForm1[Kvp.Key].Size.Height));//支持中文
                    }

                    //禁用
                    if(!ProgramForm1[Kvp.Key].TextBox.Enabled)
                    {
                        GUI.FocusControl(null);
                    }

                    if(GUI.GetNameOfFocusedControl() == Kvp.Key)
                    {
                        ProgramForm1[Kvp.Key].SetFocus();
                        useTextFieId = true;
                        activatTextFieId = Kvp.Key;
                        if(GUI.GetNameOfFocusedControl() == "" && Event.current.type == EventType.MouseDown)
                        {
                            Rect textEFieldRect = new Rect(10,10,300,40);
                            
                            if(textEFieldRect.Contains(Event.current.mousePosition))
                            {
                                Keyboard = UnityEngine.TouchScreenKeyboard.Open(ProgramForm1[Kvp.Key].Text,TouchScreenKeyboardType.Default);
                            }
                        }
                        if(Keyboard !=null && Keyboard.active)
                        {
                            ProgramForm1[Kvp.Key].Text = Keyboard.text;
                        }
                    }
                    GUILayout.EndArea();
                }
            }
        }

        void UpdateUISize()
        {
            //判断当前操作系统
            if (SystemInfo.operatingSystem.Contains("Windows"))
            {
                if (Settings.ScreenWidth != Screen.width || Settings.ScreenHeight != Screen.height)
                {
                    Settings.ScreenWidth = Screen.width;
                    Settings.ScreenHeight = Screen.height;
                }
                Screen.SetResolution(Settings.ScreenWidth, Settings.ScreenHeight, false);
            }
            else if (Application.platform == RuntimePlatform.WebGLPlayer)
            {

            }
            else
            {
                Screen.SetResolution(Settings.ScreenWidth, Settings.ScreenHeight, true);
            }
        }

        private static void CMain_Deactivate(object sender, EventArgs e)
        {
            MapControl.MapButtons = MouseButtons.None;
            Shift = false;
            Alt = false;
            Ctrl = false;
            Tilde = false;
            SpellTargetLock = false;
        }

        public static void CMain_KeyDown(object sender, KeyEventArgs e)
        {
            if(useTextFieId)
            {
                ProgramForm1[activatTextFieId].Input_KeyDown(null,e);
                return; 
            }
            Shift = e.Shift;
            Alt = e.Alt;
            Ctrl = e.Control;

            if (!String.IsNullOrEmpty(InputKeys.GetKey(KeybindOptions.TargetSpellLockOn)))
            {
                SpellTargetLock = e.KeyCode == (Keys)Enum.Parse(typeof(Keys), InputKeys.GetKey(KeybindOptions.TargetSpellLockOn), true);
            }
            else
            {
                SpellTargetLock = false;
            }


            if (e.KeyCode == Keys.Oem8)
                CMain.Tilde = true;

            try
            {
                if (e.Alt && e.KeyCode == Keys.Enter)
                {
                    ToggleFullScreen();
                    return;
                }

                if (MirScene.ActiveScene != null)
                    MirScene.ActiveScene.OnKeyDown(e);

            }
            catch (Exception ex)
            {
                SaveError(ex.ToString());
            }
        }
        public static void CMain_MouseMove(object sender, MouseEventArgs e)
        {
            // if (Settings.FullScreen || Settings.MouseClip)
            //     Cursor.Clip = Program.Form.RectangleToScreen(Program.Form.ClientRectangle);

            MPoint = e.Location;

            try
            {
                if (MirScene.ActiveScene != null)
                    MirScene.ActiveScene.OnMouseMove(e);
            }
            catch (Exception ex)
            {
                SaveError(ex.ToString());
            }
        }
        public static void CMain_KeyUp(object sender, KeyEventArgs e)
        {
            // UnityEngine.Debug.Log("抬起_______");
            // UnityEngine.Debug.Log(e.Shift);
            // UnityEngine.Debug.Log(e.Alt);
            // UnityEngine.Debug.Log(e.Control);
            Shift = e.Shift;
            Alt = e.Alt;
            Ctrl = e.Control;

            if (!String.IsNullOrEmpty(InputKeys.GetKey(KeybindOptions.TargetSpellLockOn)))
            {
                SpellTargetLock = e.KeyCode == (Keys)Enum.Parse(typeof(Keys), InputKeys.GetKey(KeybindOptions.TargetSpellLockOn), true);
            }
            else
            {
                SpellTargetLock = false;
            }

            if (e.KeyCode == Keys.Oem8)
                CMain.Tilde = false;

            foreach (KeyBind KeyCheck in CMain.InputKeys.Keylist)
            {
                if (KeyCheck.function != KeybindOptions.Screenshot) continue;
                if (KeyCheck.Key != e.KeyCode)
                    continue;
                if ((KeyCheck.RequireAlt != 2) && (KeyCheck.RequireAlt != (Alt ? 1 : 0)))
                    continue;
                if ((KeyCheck.RequireShift != 2) && (KeyCheck.RequireShift != (Shift ? 1 : 0)))
                    continue;
                if ((KeyCheck.RequireCtrl != 2) && (KeyCheck.RequireCtrl != (Ctrl ? 1 : 0)))
                    continue;
                if ((KeyCheck.RequireTilde != 2) && (KeyCheck.RequireTilde != (Tilde ? 1 : 0)))
                    continue;
                // Program.Form.CreateScreenShot();
                break;

            }
            try
            {
                if (MirScene.ActiveScene != null)
                    MirScene.ActiveScene.OnKeyUp(e);
            }
            catch (Exception ex)
            {
                SaveError(ex.ToString());
            }
        }
        public static void CMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(useTextFieId)
            {
                ProgramForm1[activatTextFieId].Input_KeyPress(null,e);
                return; 
            }
            // UnityEngine.Debug.Log("______");
            // UnityEngine.Debug.Log(e.KeyChar);
            // UnityEngine.Debug.Log((char)Keys.Tab);
            try
            {
                if (MirScene.ActiveScene != null)
                    MirScene.ActiveScene.OnKeyPress(e);
            }
            catch (Exception ex)
            {
                SaveError(ex.ToString());
            }
        }
        public static void CMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (MirScene.ActiveScene != null)
                    MirScene.ActiveScene.OnMouseClick(e);
            }
            catch (Exception ex)
            {
                SaveError(ex.ToString());
            }
        }
        public static void CMain_MouseUp(object sender, MouseEventArgs e)
        {
            MapControl.MapButtons &= ~e.Button;
            if (e.Button != MouseButtons.Right || !Settings.NewMove)
                GameScene.CanRun = false;

            try
            {
                if (MirScene.ActiveScene != null)
                    MirScene.ActiveScene.OnMouseUp(e);
            }
            catch (Exception ex)
            {
                SaveError(ex.ToString());
            }
        }
        public static void CMain_MouseDown(object sender, MouseEventArgs e)
        {
            if(ProgramFormActiveControl is TextBox)
            {
                MirTextBox textBox = ProgramFormActiveControl.Tag as MirTextBox;
                if(textBox != null && textBox.CanLoseFocus)
                    ProgramFormActiveControl = null;
                
            }
            
            if (e.Button == MouseButtons.Right && (GameScene.SelectedCell != null || GameScene.PickedUpGold))
            {
                GameScene.SelectedCell = null;
                GameScene.PickedUpGold = false;
                return;
            }

            try
            {
                if (MirScene.ActiveScene != null)
                    MirScene.ActiveScene.OnMouseDown(e);
            }
            catch (Exception ex)
            {
                SaveError(ex.ToString());
            }
        }
        public static void CMain_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (MirScene.ActiveScene != null)
                    MirScene.ActiveScene.OnMouseClick(e);
            }
            catch (Exception ex)
            {
                SaveError(ex.ToString());
            }
        }
        public static void CMain_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (MirScene.ActiveScene != null)
                    MirScene.ActiveScene.OnMouseWheel(e);
            }
            catch (Exception ex)
            {
                SaveError(ex.ToString());
            }
        }

        private static void UpdateTime()
        {
            Time = Timer.ElapsedMilliseconds;
        }

        private static void UpdateFrameTime()
        {
            if (Time >= _fpsTime)
            {
                _fpsTime = Time + 1000;
                FPS = _fps;
                _fps = 0;

                DPS = DPSCounter;
                DPSCounter = 0;
            }
            else
                _fps++;
        }

        private static bool IsDrawTime()
        {
            const int TargetUpdates = 1000 / 180; // 60 frames per second

            if (Time >= _drawTime)
            {
                _drawTime = Time + TargetUpdates;
                return true;
            }
            return false;
        }

        private static void UpdateEnviroment()
        {
            if (Time >= _cleanTime)
            {
                _cleanTime = Time + 1000;

                DXManager.Clean(); // Clean once a second.
            }

            NetWorkClinet.Process();

            if (MirScene.ActiveScene != null)
                MirScene.ActiveScene.Process();

            for (int i = 0; i < MirAnimatedControl.Animations.Count; i++)
                MirAnimatedControl.Animations[i].UpdateOffSet();

            for (int i = 0; i < MirAnimatedButton.Animations.Count; i++)
                MirAnimatedButton.Animations[i].UpdateOffSet();

            CreateHintLabel();

            if (Settings.DebugMode)
            {
                CreateDebugLabel();
            }
        }

        private static void RenderEnvironment()
        {
            // try
            // {
            //     if (DXManager.DeviceLost)
            //     {
            //         DXManager.AttemptReset();
            //         Thread.Sleep(1);
            //         return;
            //     }

            //     DXManager.Device.Clear(ClearFlags.Target, Color.Black, 0, 0);
            //     DXManager.Device.BeginScene();
            //     DXManager.Sprite.Begin(SpriteFlags.AlphaBlend);
            DXManager.SetSurface(DXManager.MainSurface);

            if (MirScene.ActiveScene != null)
                MirScene.ActiveScene.Draw();

            //     DXManager.Sprite.End();
            //     DXManager.Device.EndScene();
            //     DXManager.Device.Present();
            // }
            // catch (Direct3D9Exception ex)
            // {
            //     DXManager.DeviceLost = true;
            //     SaveError(ex.ToString());
            // }
            // catch (Exception ex)
            // {
            //     SaveError(ex.ToString());

            //     DXManager.AttemptRecovery();
            // }
        }

        private static void CreateDebugLabel()
        {
            string text;

            if (MirControl.MouseControl != null)
            {
                text = string.Format("FPS: {0}", FPS);

                text += string.Format(", DPS: {0}", DPS);

                text += string.Format(", Time: {0:HH:mm:ss UTC}", Now);

                if (MirControl.MouseControl is MapControl)
                    text += string.Format(", Co Ords: {0}", MapControl.MapLocation);

                if (MirControl.MouseControl is MirImageControl)
                    text += string.Format(", Control: {0}", MirControl.MouseControl.GetType().Name);

                if (MirScene.ActiveScene is GameScene)
                    text += string.Format(", Objects: {0}", MapControl.Objects.Count);

                if (MirScene.ActiveScene is GameScene && !string.IsNullOrEmpty(DebugText))
                    text += string.Format(", Debug: {0}", DebugText);

                if (MirObjects.MapObject.MouseObject != null)
                {
                    text += string.Format(", Target: {0}", MirObjects.MapObject.MouseObject.Name);
                }
                else
                {
                    text += string.Format(", Target: none");
                }
            }
            else
            {
                text = string.Format("FPS: {0}", FPS);
            }

            text += string.Format(", Ping: {0}", PingTime);

            text += string.Format(", Sent: {0}, Received: {1}", Functions.ConvertByteSize(BytesSent), Functions.ConvertByteSize(BytesReceived));

            text += string.Format(", TLC: {0}", DXManager.TextureList.Count(x => x.TextureValid));
            text += string.Format(", CLC: {0}", DXManager.ControlList.Count(x => x.IsDisposed == false));

            UnityEngine.Debug.Log(text);
        }

        private static void CreateHintLabel()
        {
            if (HintBaseLabel == null || HintBaseLabel.IsDisposed)
            {
                HintBaseLabel = new MirControl
                {
                    BackColour = Shared.Unity.Color.FromArgb(255, 0, 0, 0),
                    Border = true,
                    DrawControlTexture = true,
                    BorderColour = Shared.Unity.Color.FromArgb(255, 144, 144, 0),
                    ForeColour = Shared.Unity.Color.Yellow,
                    Parent = MirScene.ActiveScene,
                    NotControl = true,
                    Opacity = 0.5F
                };
            }


            if (HintTextLabel == null || HintTextLabel.IsDisposed)
            {
                HintTextLabel = new MirLabel
                {
                    AutoSize = true,
                    BackColour = Shared.Unity.Color.Transparent,
                    ForeColour = Shared.Unity.Color.Yellow,
                    Parent = HintBaseLabel,
                };

                HintTextLabel.SizeChanged += (o, e) => HintBaseLabel.Size = HintTextLabel.Size;
            }

            if (MirControl.MouseControl == null || string.IsNullOrEmpty(MirControl.MouseControl.Hint))
            {
                HintBaseLabel.Visible = false;
                return;
            }

            HintBaseLabel.Visible = true;

            HintTextLabel.Text = MirControl.MouseControl.Hint;

            Point point = MPoint.Add(-HintTextLabel.Size.Width, 20);

            if (point.X + HintBaseLabel.Size.Width >= Settings.ScreenWidth)
                point.X = Settings.ScreenWidth - HintBaseLabel.Size.Width - 1;
            if (point.Y + HintBaseLabel.Size.Height >= Settings.ScreenHeight)
                point.Y = Settings.ScreenHeight - HintBaseLabel.Size.Height - 1;

            if (point.X < 0)
                point.X = 0;
            if (point.Y < 0)
                point.Y = 0;

            HintBaseLabel.Location = point;
        }

        private static void ToggleFullScreen()
        {
            // Settings.FullScreen = !Settings.FullScreen;

            // Program.Form.FormBorderStyle = Settings.FullScreen || Settings.Borderless ? FormBorderStyle.None : FormBorderStyle.FixedDialog;

            // DXManager.Parameters.Windowed = !Settings.FullScreen;

            // Program.Form.ClientSize = new Size(Settings.ScreenWidth, Settings.ScreenHeight);

            // DXManager.ResetDevice();

            // if (MirScene.ActiveScene == GameScene.Scene)
            // {
            //     GameScene.Scene.MapControl.FloorValid = false; 
            //     GameScene.Scene.TextureValid = false;
            // }

            // Program.Form.CenterToScreen();
        }

        public void CreateScreenShot()
        {
            // string text = string.Format("[{0} Server {1}] {2} {3:hh\\:mm\\:ss}",
            //     Settings.P_ServerName.Length > 0 ? Settings.P_ServerName : "Crystal",
            //     MapControl.User != null ? MapControl.User.Name : "",
            //     Now.ToShortDateString(),
            //     Now.TimeOfDay);

            // Surface backbuffer = DXManager.Device.GetBackBuffer(0, 0);

            // using (var stream = Surface.ToStream(backbuffer, ImageFileFormat.Png))
            // {
            //     Bitmap image = new Bitmap(stream);

            //     using (Graphics graphics = Graphics.FromImage(image))
            //     {
            //         StringFormat sf = new StringFormat
            //         {
            //             LineAlignment = StringAlignment.Center,
            //             Alignment = StringAlignment.Center
            //         };

            //         graphics.DrawString(text, new Font(Settings.FontName, 9F), Brushes.Black, new Point((Settings.ScreenWidth / 2) + 3, 10), sf);
            //         graphics.DrawString(text, new Font(Settings.FontName, 9F), Brushes.Black, new Point((Settings.ScreenWidth / 2) + 4, 9), sf);
            //         graphics.DrawString(text, new Font(Settings.FontName, 9F), Brushes.Black, new Point((Settings.ScreenWidth / 2) + 5, 10), sf);
            //         graphics.DrawString(text, new Font(Settings.FontName, 9F), Brushes.Black, new Point((Settings.ScreenWidth / 2) + 4, 11), sf);
            //         graphics.DrawString(text, new Font(Settings.FontName, 9F), Brushes.White, new Point((Settings.ScreenWidth / 2) + 4, 10), sf);//SandyBrown               

            //         string path = Path.Combine(Application.StartupPath, @"Screenshots\");
            //         if (!Directory.Exists(path))
            //             Directory.CreateDirectory(path);

            //         int count = Directory.GetFiles(path, "*.png").Length;

            //         image.Save(Path.Combine(path, string.Format("Image {0}.png", count)), ImageFormat.Png);
            //     }
            // }
        }

        public static void SaveError(string ex)
        {
            try
            {
                if (Settings.RemainingErrorLogs-- > 0)
                {
                    File.AppendAllText(Settings.resRootPath + "/Error.txt", string.Format("[{0}] {1}{2}", Now, ex, Environment.NewLine));
                    UnityEngine.Debug.Log(string.Format("[{0}] {1}{2}", Now, ex, Environment.NewLine));
                }
            }
            catch
            {
            }
        }

        public static void SetResolution(int width, int height)
        {
            // if (Settings.ScreenWidth == width && Settings.ScreenHeight == height) return;

            // Settings.ScreenWidth = width;
            // Settings.ScreenHeight = height;
            // Program.Form.ClientSize = new Size(width, height);

            // DXManager.Device.Clear(ClearFlags.Target, Color.Black, 0, 0);
            // DXManager.Device.Present();
            // DXManager.ResetDevice();

            // if (!Settings.FullScreen)
            //     Program.Form.CenterToScreen();
        }

        #region 按键及触摸
        private static void HandleMouseInput()
        {
            // 模拟鼠标滚轮滚动事件
            CMouseWheel();

            // 模拟鼠标移动事件
            CMouseMove();

            // 模拟鼠标按下事件
            CMouseDown();

            // 模拟鼠标释放事件
            CMouseUp();
        }

        // 获取按下的修饰键的字符串
        private static string GetModifiers(bool isCtrl, bool isShift, bool isAlt)
        {
            string modifiers = "";
            if (isCtrl) modifiers += "Ctrl + ";
            if (isShift) modifiers += "Shift + ";
            if (isAlt) modifiers += "Alt + ";
            return modifiers.TrimEnd(' ', '+'); // 去掉多余的 "+ "
        }

        private static void HandheKeys()
        {
            // 检测 Ctrl, Shift, Alt 的状态
            bool isCtrlPressed = Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);
            bool isShiftPressed = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
            bool isAltPressed = Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt);

            // 遍历所有的按键
            foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode)))
            {
                // 检测按键是否在当前帧被按下
                if (Input.GetKeyDown(key))
                {
                    // 跳过 Ctrl, Shift, Alt 的按键，因为它们已经检测过了
                    if (key == KeyCode.LeftControl || key == KeyCode.RightControl ||
                        key == KeyCode.LeftShift || key == KeyCode.RightShift ||
                        key == KeyCode.LeftAlt || key == KeyCode.RightAlt)
                    {
                        continue;
                    }

                    // 判断并输出组合键的情况
                    if (isCtrlPressed || isShiftPressed || isAltPressed)
                    {
                        // UnityEngine.Debug.Log($"组合键按下: {GetModifiers(isCtrlPressed, isShiftPressed, isAltPressed)} + {key}");
                        var keyEventArgs = new KeyEventArgs(KeyEventArgs.GetKeys(key));
                        keyEventArgs.Alt = isAltPressed;
                        keyEventArgs.Control = isCtrlPressed;
                        keyEventArgs.Shift = isShiftPressed;
                        KeyDown?.Invoke(null, keyEventArgs);
                    }
                    else
                    {
                        // UnityEngine.Debug.Log($"单独按下的键: {key}");
                        var keyEventArgs = new KeyEventArgs(KeyEventArgs.GetKeys(key));
                        KeyDown?.Invoke(null, keyEventArgs);

                        var KeyPressEventArgs = new KeyPressEventArgs((char)KeyEventArgs.GetKeys(key));
                        KeyPress?.Invoke(null, KeyPressEventArgs);
                    }
                }

                // 键盘抬起事件
                if (key == KeyCode.LeftShift || key == KeyCode.LeftAlt || key == KeyCode.LeftControl)
                {
                    if (Input.GetKeyUp(key))
                    {
                        var keyEventArgs = new KeyEventArgs(KeyEventArgs.GetKeys(key), true);
                        keyEventArgs.Alt = isAltPressed;
                        keyEventArgs.Control = isCtrlPressed;
                        keyEventArgs.Shift = isShiftPressed;
                        KeyUp?.Invoke(null, keyEventArgs);
                    }
                }
            }
        }

        void OnApplicationFocus(bool FocusStatus){
            if(!FocusStatus)
            {
                MouseEventArgs _tmp = new MouseEventArgs(MouseButtons.None, 1, 0,0,0);
                Deactivate?.Invoke(null,_tmp);            }
        }

        private static void CMouseWheel()
        {
            float scrollDelta = Input.GetAxis("Mouse ScrollWheel");
            if (scrollDelta != 0f)
            {
                // UnityEngine.Debug.Log("鼠标滚轮 Scroll Delta: " + scrollDelta);
                MouseEventArgs _tmp = new MouseEventArgs(MouseButtons.None, 1, (int)mousePosition.x, (int)mousePosition.y, (int)(scrollDelta * SystemInformation.MouseWheelScrollDelta * 10));
                MouseWheel?.Invoke(null, _tmp);
            }
        }

        public static UnityEngine.Vector2 ScreenToWorld(UnityEngine.Vector2 screenPosition)
        {
            // 计算中心偏移
            float offsetX = (1 - Settings.SizeRatio) * Screen.width / 2f;
            float offsetY = (1 - Settings.SizeRatio) * Screen.height / 2f;

            // 将屏幕坐标转换为缩放后的世界坐标
            UnityEngine.Vector2 scaledPosition = (screenPosition - new UnityEngine.Vector2(offsetX, offsetY)) / Settings.SizeRatio;
            return scaledPosition;
        }

        public static UnityEngine.Vector2 ToUnityLocal(int x, int y)
        {
            float _x = x * Settings.SizeRatio + (1 - Settings.SizeRatio) * UnityEngine.Screen.width / 2f;
            float _y = y * Settings.SizeRatio + (1 - Settings.SizeRatio) * UnityEngine.Screen.height / 2f;
            return new UnityEngine.Vector2(_x, _y);
        }

        private static void CMouseMove()
        {
            mousePosition = Input.mousePosition;
            mousePosition = ScreenToWorld(mousePosition);
            mousePosition.y = Screen.height - mousePosition.y;

            if (MirScene.ActiveScene != null)
            {
                MouseEventArgs tmp = new MouseEventArgs(MouseButtons.None, 1, (int)mousePosition.x, (int)mousePosition.y, 1);
                if(useTextFieId)
                {
                    if(ProgramForm1.TryGetValue(activatTextFieId,out MirTextBox val))
                    {
                        ProgramForm1[activatTextFieId].Input_MouseMove(null,tmp);
                    }
                }
                MouseMove?.Invoke(null, tmp);
            }
        }

        private static void CMouseDown()
        {
            if (MirScene.ActiveScene != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    MouseEventArgs _tmp = new MouseEventArgs(MouseButtons.Left, 1, (int)mousePosition.x, (int)mousePosition.y, 1);
                    MouseDown?.Invoke(null, _tmp);
                    MouseClick?.Invoke(null, _tmp);
                }
                else if (Input.GetMouseButtonDown(1))
                {
                    MouseEventArgs _tmp = new MouseEventArgs(MouseButtons.Right, 1, (int)mousePosition.x, (int)mousePosition.y, 1);
                    MouseDown?.Invoke(null, _tmp);
                    MouseClick?.Invoke(null, _tmp);
                }
                else if (Input.GetMouseButtonDown(2))
                {
                    MouseEventArgs _tmp = new MouseEventArgs(MouseButtons.Middle, 1, (int)mousePosition.x, (int)mousePosition.y, 1);
                    MouseDown?.Invoke(null, _tmp);
                    MouseClick?.Invoke(null, _tmp);
                }
            }
        }

        private static void CMouseUp()
        {
            if (MirScene.ActiveScene != null)
            {
                if (Input.GetMouseButtonUp(0))
                {
                    MouseEventArgs _tmp = new MouseEventArgs(MouseButtons.Left, 1, (int)mousePosition.x, (int)mousePosition.y, 1);
                    MouseUp?.Invoke(null, _tmp);
                }
                else if (Input.GetMouseButtonUp(1))
                {
                    MouseEventArgs _tmp = new MouseEventArgs(MouseButtons.Right, 1, (int)mousePosition.x, (int)mousePosition.y, 1);
                    MouseUp?.Invoke(null, _tmp);
                }
                else if (Input.GetMouseButtonUp(2))
                {
                    MouseEventArgs _tmp = new MouseEventArgs(MouseButtons.Middle, 1, (int)mousePosition.x, (int)mousePosition.y, 1);
                    MouseUp?.Invoke(null, _tmp);
                }
            }
        }

        private void HandleTouchInput()
        {
            // 检测触摸屏幕
            if (Input.touchCount > 0 && MirScene.ActiveScene != null)
            {
                for (int i = 0; i < Input.touchCount; i++)
                {
                    Touch touch = Input.GetTouch(i);
                    UnityEngine.Vector2 touchPosition = touch.position;
                    touchPosition = ScreenToWorld(touchPosition);
                    touchPosition.y = Screen.height - touchPosition.y;
                    MouseEventArgs _tmp;

                    switch (touch.phase)
                    {
                        case TouchPhase.Began:

                            // 移动
                            MouseMove?.Invoke(null, new MouseEventArgs(MouseButtons.None, 1, (int)touchPosition.x, (int)touchPosition.y, 1));
                            if(useTextFieId)
                            {
                                 if(ProgramForm1.TryGetValue(activatTextFieId,out MirTextBox val))
                                 {
                                    ProgramForm1[activatTextFieId].Input_MouseMove(null,new MouseEventArgs(MouseButtons.None, 1, (int)touchPosition.x, (int)touchPosition.y, 1));
                                 } 
                            }
                            // 点击
                            _tmp = new MouseEventArgs(MouseButtons.Left, 1, (int)touchPosition.x, (int)touchPosition.y, 1);
                            // MouseDown?.Invoke(null, _tmp);
                            MouseClick?.Invoke(null, _tmp);

                            break;

                        case TouchPhase.Moved:
                            // 移动
                            MouseMove?.Invoke(null, new MouseEventArgs(MouseButtons.None, 1, (int)touchPosition.x, (int)touchPosition.y, 1));
                             if(useTextFieId)
                            {
                                 if(ProgramForm1.TryGetValue(activatTextFieId,out MirTextBox val))
                                 {
                                    ProgramForm1[activatTextFieId].Input_MouseMove(null,new MouseEventArgs(MouseButtons.None, 1, (int)touchPosition.x, (int)touchPosition.y, 1));
                                 } 
                            }

                            // 模拟滚轮
                            float scrollDelta = touch.deltaPosition.y;
                            scrollDelta = scrollDelta > 0 ? 1 : -1;
                            _tmp = new MouseEventArgs(MouseButtons.None, 1, (int)mousePosition.x, (int)mousePosition.y, (int)(scrollDelta * SystemInformation.MouseWheelScrollDelta));
                            MouseWheel?.Invoke(null, _tmp);

                            break;

                        case TouchPhase.Ended:
                            // 移动
                            MouseMove?.Invoke(null, new MouseEventArgs(MouseButtons.None, 1, (int)touchPosition.x, (int)touchPosition.y, 1));
                             if(useTextFieId)
                            {
                                 if(ProgramForm1.TryGetValue(activatTextFieId,out MirTextBox val))
                                 {
                                    ProgramForm1[activatTextFieId].Input_MouseMove(null,new MouseEventArgs(MouseButtons.None, 1, (int)touchPosition.x, (int)touchPosition.y, 1));
                                 } 
                            }

                            // 点击
                            _tmp = new MouseEventArgs(MouseButtons.Left, 1, (int)touchPosition.x, (int)touchPosition.y, 1);
                            MouseDown?.Invoke(null, _tmp);
                            MouseClick?.Invoke(null, _tmp);

                            // 抬起
                            _tmp = new MouseEventArgs(MouseButtons.Left, 1, (int)touchPosition.x, (int)touchPosition.y, 1);
                            MouseUp?.Invoke(null, _tmp);
                            break;
                    }
                }
            }
        }
        #endregion
    }
}
