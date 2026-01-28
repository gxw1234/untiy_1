/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class ScanLoginButton : GButton
    {
        public Controller button;
        public GImage n0;
        public const string URL = "ui://us2ut3jfpz626e";

        public static ScanLoginButton CreateInstance()
        {
            return (ScanLoginButton)UIPackage.CreateObject("UILoadingRes", "ScanLoginButton");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
        }
    }
}