using System;
using System.Linq;
using Client.MirGraphics;
using Shared.Unity;
using Shared.Unity.Imaging;
using Unity.VisualScripting;

namespace Client.MirControls
{
    public sealed class MirTextBox : MirControl
    {
        #region Back Color

        protected override void OnBackColourChanged()
        {
            base.OnBackColourChanged();
            if (TextBox != null && !TextBox.IsDisposed)
                TextBox.BackColor = BackColour;
        }

        #endregion

        #region Enabled

        protected override void OnEnabledChanged()
        {
            base.OnEnabledChanged();
            if (TextBox != null && !TextBox.IsDisposed)
                TextBox.Enabled = Enabled;
        }

        #endregion

        #region Fore Color

        protected override void OnForeColourChanged()
        {
            base.OnForeColourChanged();
            if (TextBox != null && !TextBox.IsDisposed)
                TextBox.ForeColor = ForeColour;
        }

        #endregion

        #region Location

        protected override void OnLocationChanged()
        {
            base.OnLocationChanged();
            if (TextBox != null && !TextBox.IsDisposed)
                TextBox.Location = DisplayLocation;

            TextureValid = false;
            Redraw();
        }

        #endregion

        #region Max Length

        public int MaxLength
        {
            get
            {
                if (TextBox != null && !TextBox.IsDisposed)
                    return TextBox.MaxLength;
                return -1;
            }
            set
            {
                if (TextBox != null && !TextBox.IsDisposed)
                    TextBox.MaxLength = value;
            }
        }

        #endregion

        #region Parent

        protected override void OnParentChanged()
        {
            base.OnParentChanged();
            if (TextBox != null && !TextBox.IsDisposed)
                OnVisibleChanged();
        }

        #endregion

        #region Password

        public bool Password
        {
            get
            {
                if (TextBox != null && !TextBox.IsDisposed)
                    return TextBox.UseSystemPasswordChar;
                return false;
            }
            set
            {
                if (TextBox != null && !TextBox.IsDisposed)
                    TextBox.UseSystemPasswordChar = value;
            }
        }

        #endregion

        #region Font

        public Shared.Unity.Font Font
        {
            get
            {
                if (TextBox != null && !TextBox.IsDisposed)
                    return TextBox.Font;
                
                return TextBox.Font;
            }
            set
            {
                if (TextBox != null && !TextBox.IsDisposed)
                    TextBox.Font = ScaleFont(value);
            }
        }

        #endregion

        #region Size

        protected override void OnSizeChanged()
        {
            TextBox.Size = Size;

            DisposeTexture();

            _size = Size;

            if (TextBox != null && !TextBox.IsDisposed)
                base.OnSizeChanged();
        }

        #endregion
        
        #region TextBox

        public bool CanLoseFocus;
        public readonly TextBox TextBox;
        private Pen CaretPen;

        #endregion

        #region Label

        public string Text
        {
            get
            {
                if (TextBox != null && !TextBox.IsDisposed)
                    return TextBox.Text;
                return null;
            }
            set
            {
                if (TextBox != null && !TextBox.IsDisposed)
                    TextBox.Text = value;
            }
        }
        public string[] MultiText
        {
            get
            {
                if (TextBox != null && !TextBox.IsDisposed)
                    return TextBox.Lines;
                return null;
            }
            set
            {
                if (TextBox != null && !TextBox.IsDisposed)
                    TextBox.Lines = value;
            }
        }

        #endregion

        #region Visible

        public override bool Visible
        {
            get
            {
                return base.Visible;
            }
            set
            {
                base.Visible = value;
                OnVisibleChanged();
            }
        }

        protected override void OnVisibleChanged()
        {
            base.OnVisibleChanged();

            if (TextBox != null && !TextBox.IsDisposed)
                TextBox.Visible = Visible;
        }
        private void TextBox_VisibleChanged(object sender, EventArgs e)
        {
            DialogChanged();

            if (TextBox.Visible && TextBox.CanFocus)
                if (CMain.ProgramFormActiveControl == null)
                    CMain.ProgramFormActiveControl = TextBox;

            // if (!TextBox.Visible)
            //     if (CMain.ProgramFormActiveControl == TextBox)
                    // CMain.ProgramForm1.Focus();
        }
        private void SetFocus(object sender, EventArgs e)
        {
            if (TextBox.Visible)
                TextBox.VisibleChanged -= SetFocus;
            if (TextBox.Parent != null)
                TextBox.ParentChanged -= SetFocus;

            if (TextBox.CanFocus) TextBox.Focus();
            else if (TextBox.Visible && TextBox.Parent != null)
                CMain.ProgramFormActiveControl = TextBox;
        }

        #endregion

        #region MultiLine

        public override void MultiLine()
        {
            TextBox.Multiline = true;
            TextBox.Size = Size;

            DisposeTexture();
            Redraw();
        }

        #endregion

        public string MirTextBox_name = "";
        public UnityEngine.GUIStyle style2; 

        public MirTextBox()
        {
            style2 = CMain.style; 

            BackColour = Color.Black;

            DrawControlTexture = true;
            TextureValid = false;

            TextBox = new TextBox
            {
                BackColor = BackColour,
                BorderStyle = BorderStyle.None,
                Font = new Shared.Unity.Font(Settings.FontName, 12F * 96f / 96),
                ForeColor = ForeColour,
                Location = DisplayLocation,
                Size = Size,
                Visible = Visible,
                Tag = this,
                // Cursor = CMain.Cursors[(byte)MouseCursor.TextPrompt]
            };

            CaretPen = new Pen(ForeColour, 1);

            TextBox.VisibleChanged += TextBox_VisibleChanged;
            TextBox.ParentChanged += TextBox_VisibleChanged;
            TextBox.KeyUp += TextBoxOnKeyUp;  
            TextBox.KeyPress += TextBox_KeyPress;

            TextBox.KeyPress += TextBox_NeedRedraw; 
            TextBox.KeyUp += TextBox_NeedRedraw;
            TextBox.MouseDown += TextBox_NeedRedraw;
            TextBox.MouseUp += TextBox_NeedRedraw;
            TextBox.LostFocus += TextBox_NeedRedraw;
            TextBox.GotFocus += TextBox_NeedRedraw;
            TextBox.MouseWheel += TextBox_NeedRedraw;

            Shown += MirTextBox_Shown;
            TextBox.MouseMove += CMain.CMain_MouseMove;

            MirTextBox_name = Guid.NewGuid().ToString("N");
            CMain.AddTextFieldObject(MirTextBox_name,this);
        }

        private void TextBox_NeedRedraw(object sender, EventArgs e)
        {
            TextureValid = false;
            Redraw();
        }

        protected unsafe override void CreateTexture()
        {
            if (!Settings.FullScreen) return;

            if (Size.IsEmpty)
                return;

            if (TextureSize != Size)
                DisposeTexture();

            if (ControlTexture == null)
            {
                // DXManager.ControlList.Add(this);

                ControlTexture = new UnityEngine.Texture2D(Size.Width, Size.Height,UnityEngine.TextureFormat.ARGB32,false);
                UnityEngine.Color[] pixels = ControlTexture.GetPixels();
                for (int i = 0; i < pixels.Length; i++)
                {
                    pixels[i] = BackColour.ToUnity();
                }
                ControlTexture.SetPixels(pixels);
                ControlTexture.Apply();
                TextureSize = Size;
            }

            UnityEngine.GUI.DrawTexture(new UnityEngine.Rect(DisplayLocation.X,DisplayLocation.Y,Size.Width,Size.Height),ControlTexture);

            //处理样式
            CMain.style2.fontSize = (int)Font.Size;
            CMain.style2.richText = true;
            CMain.style2.normal.textColor = ForeColour.ToUnity();
            style2 = CMain.style2;
            //输入事件
             if(CMain.ProgramForm1.TryGetValue(MirTextBox_name,out MirTextBox value))
            {
                Text = CMain.ProgramForm1[MirTextBox_name].Text;
            }

            if(Password)
            {
                UnityEngine.GUI.Label(new UnityEngine.Rect(DisplayLocation.X,DisplayLocation.Y,Size.Width,Size.Height),new string('*',Text.Length),CMain.style2);
            }else{
                UnityEngine.GUI.Label(new UnityEngine.Rect(DisplayLocation.X,DisplayLocation.Y,Size.Width,Size.Height),Text,CMain.style2);
            }
            //光标位置
            Point caret = GetCaretPosition();
            if(TextBox.Focused)
            {
                //计算光标的起点和终点
                UnityEngine.Vector2 caretStart = new UnityEngine.Vector2(caret.X,caret.Y);
                UnityEngine.Vector2 caretEnd = new UnityEngine.Vector2(caret.X,caret.Y+CMain.style2.fontSize);

                UnityEngine.GL.Begin(UnityEngine.GL.LINES);
                UnityEngine.GL.Color(Color.White.ToUnity());
                UnityEngine.GL.Vertex(caretStart);
                UnityEngine.GL.Vertex(caretEnd);
                UnityEngine.GL.End();
            }
            // TextureValid = true;
        }

        private Point GetCaretPosition()
        {
            Point result = TextBox.GetPositionFromCharIndex(TextBox.SelectionStart);

            if (result.X == 0 && TextBox.Text.Length > 0)
            {
                result = TextBox.GetPositionFromCharIndex(TextBox.Text.Length - 1);
                int s = result.X / TextBox.Text.Length;
                result.X = (int)(result.X + (s * 1.46));
                result.Y = TextBox.GetLineFromCharIndex(TextBox.SelectionStart) * TextBox.Font.Height;
            }

            return result;
        }

        public void TextBoxOnKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.PrintScreen:
                    CMain.CMain_KeyUp(sender, e);
                    break;

            }
        }

        public void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e.KeyChar == (char)Keys.Escape)
            {
                CMain.ProgramFormActiveControl = null;
                e.Handled = true;
            }
        }


        void MirTextBox_Shown(object sender, EventArgs e)
        {
            // TextBox.Parent = CMain.ProgramForm1;
            CMain.Ctrl = false;
            CMain.Shift = false;
            CMain.Alt = false;
            CMain.Tilde = false;

            TextureValid = false;
            SetFocus();
        }

        public void SetFocus()
        {
            if (!TextBox.Visible)
                TextBox.VisibleChanged += SetFocus;
            else if (TextBox.Parent == null)
                TextBox.ParentChanged += SetFocus;
            else
                TextBox.Focus();
        }

        public void DialogChanged()
        {
            MirMessageBox box1 = null;
            MirInputBox box2 = null;
            MirAmountBox box3 = null;

            if (MirScene.ActiveScene != null && MirScene.ActiveScene.Controls.Count > 0)
            {
                box1 = (MirMessageBox) MirScene.ActiveScene.Controls.FirstOrDefault(ob => ob is MirMessageBox);
                box2 = (MirInputBox) MirScene.ActiveScene.Controls.FirstOrDefault(O => O is MirInputBox);
                box3 = (MirAmountBox) MirScene.ActiveScene.Controls.FirstOrDefault(ob => ob is MirAmountBox);
            }


            if ((box1 != null && box1 != Parent) || (box2 != null && box2 != Parent)  || (box3 != null && box3 != Parent))
                TextBox.Visible = false;
            else
                TextBox.Visible = Visible;
        }


        #region Disposable

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (!disposing) return;

            if (!TextBox.IsDisposed)
            {
                TextBox.Dispose();
                CMain.DelTextFieldObject(MirTextBox_name);
            }
        }

        //接入鼠标键盘事件
        public void Input_KeyDown(object sender,KeyEventArgs e)
        {
            TextBox.SimulateKeyDown(e.KeyCode);
        }

        public void Input_KeyPress(object sender,KeyPressEventArgs e)
        {
            TextBox.SimulateKeyPress(e.KeyChar);
        }

        public void Input_MouseMove(object sender,MouseEventArgs e)
        {
            TextBox.SimulateMouseMove(e.X,e.Y,e.Button);
        }

        public void Input_MouseDown(object sender,MouseEventArgs e)
        {
            TextBox.SimulateMouseDown(e.X,e.Y,e.Button);
        }

        public void Input_MouseUP(object sender,MouseEventArgs e)
        {
            TextBox.SimulateMouseUp(e.X,e.Y,e.Button);
        }

        #endregion
    }
}
