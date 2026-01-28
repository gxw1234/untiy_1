/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class SelAllBtn : GButton
    {
        public Controller button;
        public GImage Img1016l;
        public GImage Img115e5;
        public GTextField ChatEdit30;
        public const string URL = "ui://use7blkkqgn27s";

        public static SelAllBtn CreateInstance()
        {
            return (SelAllBtn)UIPackage.CreateObject("BaseRes", "SelAllBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1016l = (GImage)GetChild("Img1016l");
            Img115e5 = (GImage)GetChild("Img115e5");
            ChatEdit30 = (GTextField)GetChild("ChatEdit30");
        }
    }
}