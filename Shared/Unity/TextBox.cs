using System;
using System.Collections.Generic;

namespace Shared.Unity
{
    public enum BorderStyle
    {
        None,
        FixedSingle,
        Fixed3D
    }

    public class TextBox
    {
        private string text = string.Empty;
        private int selectionStart;
        private int selectionLength;
        private bool multiline;
        private Color backColor;
        private BorderStyle borderStyle;
        private Font font;
        private Color foreColor;
        private Point location;
        private Size size;
        private bool visible;
        private bool enabled = true; // 新增的Enabled属性
        private object tag;
        private object parent;
        private List<string> lines = new List<string>();
        private int maxLines = 10;
        private bool readOnly = false;
        private bool acceptsReturn = false;
        private IntPtr handle = IntPtr.Zero;
        private int maxLength = int.MaxValue;
        private bool useSystemPasswordChar = false;
        private bool isDisposed = false;
        private bool canFocus = true;
        private bool isFocused = false; // 表示当前是否已获得焦点
        private bool focused;

        // 属性
        public string[] Lines
        {
            get => lines.ToArray();
            set
            {
                if (value != null)
                {
                    lines = new List<string>(value);
                    ApplyMaxLines();
                }
            }
        }

        public Font Font
        {
            get => font;
            set
            {
                if (value != null)
                {
                    font = value;
                }
            }
        }

        public bool UseSystemPasswordChar
        {
            get => useSystemPasswordChar;
            set => useSystemPasswordChar = value;
        }

        public string Text
        {
            get => text;
            set
            {
                if (!readOnly)
                {
                    text = value.Length > maxLength ? value.Substring(0, maxLength) : value;
                    UpdateLines();
                    OnTextChanged(EventArgs.Empty);
                    selectionStart = text.Length; // 光标自动移到文本末尾
                }
            }
        }

        public int MaxLength
        {
            get => maxLength;
            set
            {
                if (maxLength != value)
                {
                    maxLength = value;
                    if (text.Length > maxLength)
                        text = text.Substring(0, maxLength);
                }
            }
        }

        public bool Multiline
        {
            get => multiline;
            set
            {
                multiline = value;
                UpdateLines();
            }
        }

        public int SelectionStart
        {
            get => selectionStart;
            set
            {
                selectionStart = Math.Clamp(value, 0, text.Length); // 确保光标位置在合法范围内
            }
        }

        public int SelectionLength
        {
            get => selectionLength;
            set
            {
                selectionLength = Math.Clamp(value, 0, text.Length - selectionStart); // 确保选择的长度不超出文本范围
            }
        }

        public Color BackColor
        {
            get => backColor;
            set => backColor = value;
        }

        public Color ForeColor
        {
            get => foreColor;
            set => foreColor = value;
        }

        public Point Location
        {
            get => location;
            set => location = value;
        }

        public Size Size
        {
            get => size;
            set => size = value;
        }

        public bool Visible
        {
            get => visible;
            set
            {
                if (visible != value)
                {
                    visible = value;
                    OnVisibleChanged(EventArgs.Empty);
                }
            }
        }

        public bool Enabled
        {
            get => enabled;
            set
            {
                if (enabled != value)
                {
                    enabled = value;
                    OnEnabledChanged(EventArgs.Empty);
                }
            }
        }

        public BorderStyle BorderStyle
        {
            get => borderStyle;
            set => borderStyle = value;
        }

        public bool AcceptsReturn
        {
            get => acceptsReturn;
            set => acceptsReturn = value;
        }

        public bool ReadOnly
        {
            get => readOnly;
            set => readOnly = value;
        }

        public object Tag
        {
            get => tag;
            set => tag = value;
        }

        public object Parent
        {
            get => parent;
            set
            {
                if (parent != value)
                {
                    parent = value;
                    OnParentChanged(EventArgs.Empty);
                }
            }
        }

        public bool CanFocus
        {
            get => canFocus;
            set => canFocus = value;
        }

        public bool IsDisposed
        {
            get => isDisposed;
            private set => isDisposed = value;
        }

        public bool IsFocused
        {
            get => isFocused;
            set
            {
                if (isFocused != value)
                {
                    isFocused = value;
                    if (isFocused)
                        OnGotFocus(EventArgs.Empty);
                    else
                        OnLostFocus(EventArgs.Empty);
                }
            }
        }


        // 新增 Focused 属性
        public bool Focused
        {
            get => focused;
            set
            {
                focused = value;
                // 在这里可以触发 GotFocus 和 LostFocus 事件
                if (focused)
                {
                    OnGotFocus(EventArgs.Empty);
                }
                else
                {
                    OnLostFocus(EventArgs.Empty);
                }
            }
        }

        public void AppendText(string value)
        {
            if (!readOnly)
            {
                text += value;
                UpdateLines();
                selectionStart = text.Length; // 将光标移到文本末尾
            }
        }

        public void Select(int start, int length)
        {
            SelectionStart = start;
            SelectionLength = length;
        }

        public void SelectAll()
        {
            SelectionStart = 0;
            SelectionLength = text.Length;
        }

        public void Copy()
        {
            if (selectionLength > 0)
            {
                Console.WriteLine(text.Substring(selectionStart, selectionLength));
            }
        }

        public void SimulateKeyDown(Keys keyCode)
        {
            var args = new KeyEventArgs(keyCode);
            KeyDown?.Invoke(this, args);
        }

        public void SimulateKeyPress(char keyChar)
        {
            var args = new KeyPressEventArgs(keyChar);
            KeyPress?.Invoke(this, args);
        }

        public void SimulateMouseMove(int x, int y, MouseButtons button = MouseButtons.None)
        {
            var args = new MouseEventArgs(button, 0, x, y, 0);
            MouseMove?.Invoke(this, args);
        }

        public void SimulateMouseDown(int x, int y, MouseButtons button = MouseButtons.Left)
        {
            var args = new MouseEventArgs(button, 1, x, y, 0);
            MouseDown?.Invoke(this, args);
        }

        public void SimulateMouseUp(int x, int y, MouseButtons button = MouseButtons.Left)
        {
            var args = new MouseEventArgs(button, 1, x, y, 0);
            MouseUp?.Invoke(this, args);
        }

        public void Focus()
        {
            if (CanFocus && Enabled)
            {
                IsFocused = true;
            }
        }

        public void Dispose()
        {
            if (!isDisposed)
            {
                isDisposed = true;
                // 清理资源
            }
        }

        // 事件
        public event EventHandler TextChanged;
        public event EventHandler GotFocus;
        public event EventHandler LostFocus;
        public event EventHandler VisibleChanged;
        public event EventHandler EnabledChanged;
        public event EventHandler ParentChanged;
        public event KeyPressEventHandler KeyPress;
        public event MouseEventHandler MouseMove;
        public event MouseEventHandler MouseDown;
        public event MouseEventHandler MouseUp;
        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;
        public event MouseEventHandler MouseWheel;

        // 方法
        private void UpdateLines()
        {
            if (multiline)
            {
                lines = new List<string>(text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None));
                ApplyMaxLines();
            }
            else
            {
                lines = new List<string> { text };
            }
        }

        private void ApplyMaxLines()
        {
            if (lines.Count > maxLines)
            {
                lines.RemoveRange(maxLines, lines.Count - maxLines);
            }
        }

        protected virtual void OnTextChanged(EventArgs e) => TextChanged?.Invoke(this, e);
        protected virtual void OnVisibleChanged(EventArgs e) => VisibleChanged?.Invoke(this, e);
        protected virtual void OnEnabledChanged(EventArgs e) => EnabledChanged?.Invoke(this, e);
        protected virtual void OnParentChanged(EventArgs e) => ParentChanged?.Invoke(this, e);
        protected virtual void OnGotFocus(EventArgs e) => GotFocus?.Invoke(this, e);
        protected virtual void OnLostFocus(EventArgs e) => LostFocus?.Invoke(this, e);

        // 获取光标位置的 x 和 y 坐标（像素），基于字符索引
        public Point GetPositionFromCharIndex(int index)
        {
            if (index < 0 || index > text.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            // 遍历每一行，找到该索引对应的行号和在该行内的位置
            int currentIndex = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                int lineLength = lines[i].Length;
                if (currentIndex + lineLength >= index)
                {
                    int charIndexInLine = index - currentIndex;
                    // 假设每个字符的宽度为一定值，根据Font的大小或实际情况可调整
                    int x = charIndexInLine * (int)font.Size; // 简化版计算字符的x位置
                    int y = i * (int)font.Size; // 行高按字体大小来定
                    return new Point(x, y);
                }
                currentIndex += lineLength + 1; // 加 1 是因为 \n
            }

            // 如果索引超出，返回最末位置
            return new Point(0, lines.Count * (int)font.Size);
        }

        // 根据字符索引返回它所处的行号
        public int GetLineFromCharIndex(int index)
        {
            if (index < 0 || index > text.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            int currentIndex = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                currentIndex += lines[i].Length + 1; // 加 1 是因为换行符
                if (currentIndex > index)
                    return i;
            }

            return lines.Count - 1; // 如果超出文本长度，返回最后一行
        }
    }
}
