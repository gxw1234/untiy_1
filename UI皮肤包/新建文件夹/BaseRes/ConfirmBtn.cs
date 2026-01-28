/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ConfirmBtn : GButton
    {
        public Controller button;
        public GImage Img105l8;
        public GImage Img11hi3;
        public GTextField ChatEdit171;
        public const string URL = "ui://use7blkkqgn27u";

        public static ConfirmBtn CreateInstance()
        {
            return (ConfirmBtn)UIPackage.CreateObject("BaseRes", "ConfirmBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img105l8 = (GImage)GetChild("Img105l8");
            Img11hi3 = (GImage)GetChild("Img11hi3");
            ChatEdit171 = (GTextField)GetChild("ChatEdit171");
        }
    }
}