/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DressBtn : GButton
    {
        public Controller button;
        public GImage Img568qbj;
        public GImage Img569j4r;
        public GTextField ChatEdit2;
        public const string URL = "ui://us2ut3jfr7r839";

        public static DressBtn CreateInstance()
        {
            return (DressBtn)UIPackage.CreateObject("UILoadingRes", "DressBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img568qbj = (GImage)GetChild("Img568qbj");
            Img569j4r = (GImage)GetChild("Img569j4r");
            ChatEdit2 = (GTextField)GetChild("ChatEdit2");
        }
    }
}