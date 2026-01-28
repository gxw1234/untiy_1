/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class LoginButton : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public const string URL = "ui://us2ut3jfps2xz";

        public static LoginButton CreateInstance()
        {
            return (LoginButton)UIPackage.CreateObject("UILoadingRes", "LoginButton");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
        }
    }
}