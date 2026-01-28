namespace Shared.Unity
{
    public class Font
    {
        public string Name { get; set; }
        public float Size { get; set; }
        public FontStyle Style { get; set; }

        public static Font Default => new Font("Arial", 12, FontStyle.Regular);

        public Font(string name, float size)
        {
            Name = name;
            Size = size;
            Style = FontStyle.Regular;
        }

        public Font(string name, float size, FontStyle style)
        {
            Name = name;
            Size = size;
            Style = style;
        }

        public bool Equals(Font otherFont)
        {
            if (otherFont == null)
                return false;

            return Name == otherFont.Name && Size == otherFont.Size && Style == otherFont.Style;
        }

        public override string ToString()
        {
            return $"{Name}, {Size}, {Style}";
        }

        public int Height
        {
            get
            {
                return 20;
            }
        }

        // 重载 == 操作符
        public static bool operator ==(Font f1, Font f2)
        {
            if (ReferenceEquals(f1, null))
                return ReferenceEquals(f2, null);

            return f1.Equals(f2);
        }

        // 重载 != 操作符
        public static bool operator !=(Font f1, Font f2)
        {
            return !(f1 == f2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Font font)
            {
                return Equals(font);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Name, Size, Style).GetHashCode();
        }
    }

    public enum FontStyle
    {
        Regular = 0x0,
        Bold = 0x1,
        Italic = 0x2,
        Underline = 0x4,
        Strikeout = 0x8
    }

    public enum TextFormatFlags
    {
        Bottom = 0x00000008,
        EndEllipsis = 0x00008000,
        ExpandTabs = 0x00000040,
        ExternalLeading = 0x00000200,
        Default = 0x00000000,
        HidePrefix = 0x00100000,
        HorizontalCenter = 0x00000001,
        Internal = 0x00001000,
        Left = 0x00000000,
        ModifyString = 0x00010000,
        NoClipping = 0x00000100,
        NoPrefix = 0x00000800,
        NoFullWidthCharacterBreak = 0x00080000,
        PathEllipsis = 0x00004000,
        PrefixOnly = 0x00200000,
        Right = 0x00000002,
        RightToLeft = 0x00020000,
        SingleLine = 0x00000020,
        TextBoxControl = 0x00002000,
        Top = 0x00000000,
        VerticalCenter = 0x00000004,
        WordBreak = 0x00000010,
        WordEllipsis = 0x00040000,
        PreserveGraphicsClipping = 0x01000000,
        PreserveGraphicsTranslateTransform = 0x02000000,
        GlyphOverhangPadding = 0x00000000,
        NoPadding = 0x10000000,
        LeftAndRightPadding = 0x20000000
    }
}
