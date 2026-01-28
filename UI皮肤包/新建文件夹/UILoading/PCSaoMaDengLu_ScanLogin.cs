/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoading
{
    public partial class PCSaoMaDengLu_ScanLogin : GComponent
    {
        public GImage background;
        public GButton close;
        public GLoader Image;
        public const string URL = "ui://up3anxyrpfmg40";

        public static PCSaoMaDengLu_ScanLogin CreateInstance()
        {
            return (PCSaoMaDengLu_ScanLogin)UIPackage.CreateObject("UILoading", "PC扫码登录_ScanLogin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            background = (GImage)GetChild("background");
            close = (GButton)GetChild("close");
            Image = (GLoader)GetChild("Image");
        }
    }
}