/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class YouXianBangZhu_Help : GComponent
    {
        public GImage n2;
        public GButton CloseButton;
        public GComponent n5;
        public const string URL = "ui://jyvofh5es336vn2sm";

        public static YouXianBangZhu_Help CreateInstance()
        {
            return (YouXianBangZhu_Help)UIPackage.CreateObject("UI", "优先帮助_Help");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n2 = (GImage)GetChild("n2");
            CloseButton = (GButton)GetChild("CloseButton");
            n5 = (GComponent)GetChild("n5");
        }
    }
}