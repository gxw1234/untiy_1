/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class ConfirmBtn : GButton
    {
        public Controller button;
        public GImage Img396h0r;
        public GImage Img3974g2;
        public const string URL = "ui://us2ut3jfk2h33v";

        public static ConfirmBtn CreateInstance()
        {
            return (ConfirmBtn)UIPackage.CreateObject("UILoadingRes", "ConfirmBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img396h0r = (GImage)GetChild("Img396h0r");
            Img3974g2 = (GImage)GetChild("Img3974g2");
        }
    }
}