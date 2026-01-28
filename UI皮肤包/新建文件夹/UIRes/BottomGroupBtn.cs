/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottomGroupBtn : GButton
    {
        public Controller button;
        public GImage Img8456c3;
        public GImage Img845ln5;
        public const string URL = "ui://jk0io98jv9b11o";

        public static BottomGroupBtn CreateInstance()
        {
            return (BottomGroupBtn)UIPackage.CreateObject("UIRes", "BottomGroupBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img8456c3 = (GImage)GetChild("Img8456c3");
            Img845ln5 = (GImage)GetChild("Img845ln5");
        }
    }
}