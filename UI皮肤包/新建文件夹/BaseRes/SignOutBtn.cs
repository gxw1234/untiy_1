/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class SignOutBtn : GButton
    {
        public Controller button;
        public GImage Img1023m;
        public GImage Img1132n;
        public GTextField ChatEdit5;
        public const string URL = "ui://use7blkkqgn26x";

        public static SignOutBtn CreateInstance()
        {
            return (SignOutBtn)UIPackage.CreateObject("BaseRes", "SignOutBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1023m = (GImage)GetChild("Img1023m");
            Img1132n = (GImage)GetChild("Img1132n");
            ChatEdit5 = (GTextField)GetChild("ChatEdit5");
        }
    }
}