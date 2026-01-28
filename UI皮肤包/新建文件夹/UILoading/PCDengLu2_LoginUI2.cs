/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoading
{
    public partial class PCDengLu2_LoginUI2 : GComponent
    {
        public GImage background;
        public GImage title2;
        public GImage title1;
        public GTextField Phone;
        public GTextField Code;
        public GTextInput PhoneInput;
        public GTextInput CodeInput;
        public GButton RegisterButton;
        public GButton LoginButton;
        public GButton ResetPasswordButton;
        public GButton ObtainButton;
        public GButton AccountLoginButton;
        public GButton ScanLoginButton;
        public const string URL = "ui://up3anxyrps2xb";

        public static PCDengLu2_LoginUI2 CreateInstance()
        {
            return (PCDengLu2_LoginUI2)UIPackage.CreateObject("UILoading", "PC登录2_LoginUI2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            background = (GImage)GetChild("background");
            title2 = (GImage)GetChild("title2");
            title1 = (GImage)GetChild("title1");
            Phone = (GTextField)GetChild("Phone");
            Code = (GTextField)GetChild("Code");
            PhoneInput = (GTextInput)GetChild("PhoneInput");
            CodeInput = (GTextInput)GetChild("CodeInput");
            RegisterButton = (GButton)GetChild("RegisterButton");
            LoginButton = (GButton)GetChild("LoginButton");
            ResetPasswordButton = (GButton)GetChild("ResetPasswordButton");
            ObtainButton = (GButton)GetChild("ObtainButton");
            AccountLoginButton = (GButton)GetChild("AccountLoginButton");
            ScanLoginButton = (GButton)GetChild("ScanLoginButton");
        }
    }
}