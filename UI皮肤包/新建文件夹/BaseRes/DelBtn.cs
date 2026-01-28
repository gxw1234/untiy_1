/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DelBtn : GButton
    {
        public Controller button;
        public GImage Img10umw;
        public GImage Img11345;
        public GTextField ChatEdit9;
        public const string URL = "ui://use7blkkqgn26z";

        public static DelBtn CreateInstance()
        {
            return (DelBtn)UIPackage.CreateObject("BaseRes", "DelBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10umw = (GImage)GetChild("Img10umw");
            Img11345 = (GImage)GetChild("Img11345");
            ChatEdit9 = (GTextField)GetChild("ChatEdit9");
        }
    }
}