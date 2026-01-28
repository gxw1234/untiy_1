/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoading
{
    public partial class PCDengLu_LoginUI : GComponent
    {
        public GImage background;
        public GImage title2;
        public GImage title1;
        public GTextField UserID;
        public GTextField UserPassword;
        public GTextInput UserIDInput;
        public GTextInput UserPasswordInput;
        public GButton RegisterButton;
        public GButton LoginButton;
        public GButton ResetPassword;
        public GButton PhoneLogin;
        public GButton ScanLoginButton;
        public const string URL = "ui://up3anxyrps2x0";

        public static PCDengLu_LoginUI CreateInstance()
        {
            return (PCDengLu_LoginUI)UIPackage.CreateObject("UILoading", "PC登录_LoginUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            background = (GImage)GetChild("background");
            title2 = (GImage)GetChild("title2");
            title1 = (GImage)GetChild("title1");
            UserID = (GTextField)GetChild("UserID");
            UserPassword = (GTextField)GetChild("UserPassword");
            UserIDInput = (GTextInput)GetChild("UserIDInput");
            UserPasswordInput = (GTextInput)GetChild("UserPasswordInput");
            RegisterButton = (GButton)GetChild("RegisterButton");
            LoginButton = (GButton)GetChild("LoginButton");
            ResetPassword = (GButton)GetChild("ResetPassword");
            PhoneLogin = (GButton)GetChild("PhoneLogin");
            ScanLoginButton = (GButton)GetChild("ScanLoginButton");
        }
    }
}