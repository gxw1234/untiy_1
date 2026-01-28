/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class SwitchBtn : GButton
    {
        public Controller button;
        public GImage Img10v6b;
        public GImage Img11m1n;
        public GTextField ChatEdit7;
        public const string URL = "ui://use7blkkqgn26y";

        public static SwitchBtn CreateInstance()
        {
            return (SwitchBtn)UIPackage.CreateObject("BaseRes", "SwitchBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10v6b = (GImage)GetChild("Img10v6b");
            Img11m1n = (GImage)GetChild("Img11m1n");
            ChatEdit7 = (GTextField)GetChild("ChatEdit7");
        }
    }
}