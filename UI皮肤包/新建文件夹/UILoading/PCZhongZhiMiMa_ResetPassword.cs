/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoading
{
    public partial class PCZhongZhiMiMa_ResetPassword : GComponent
    {
        public GImage background;
        public GTextField UserID;
        public GImage title4;
        public GImage title3;
        public GImage title2;
        public GImage title1;
        public GTextField PhoneNumber;
        public GTextField NewPassword;
        public GTextField Code;
        public GTextInput UserIDInput;
        public GTextInput NewPasswordInput;
        public GTextInput PhoneNumberInput;
        public GTextInput CodeInput;
        public GButton close;
        public GTextField Title;
        public GButton SubmitButton;
        public GButton ObtainButton;
        public const string URL = "ui://up3anxyrps2x2";

        public static PCZhongZhiMiMa_ResetPassword CreateInstance()
        {
            return (PCZhongZhiMiMa_ResetPassword)UIPackage.CreateObject("UILoading", "PC重置密码_ResetPassword");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            background = (GImage)GetChild("background");
            UserID = (GTextField)GetChild("UserID");
            title4 = (GImage)GetChild("title4");
            title3 = (GImage)GetChild("title3");
            title2 = (GImage)GetChild("title2");
            title1 = (GImage)GetChild("title1");
            PhoneNumber = (GTextField)GetChild("PhoneNumber");
            NewPassword = (GTextField)GetChild("NewPassword");
            Code = (GTextField)GetChild("Code");
            UserIDInput = (GTextInput)GetChild("UserIDInput");
            NewPasswordInput = (GTextInput)GetChild("NewPasswordInput");
            PhoneNumberInput = (GTextInput)GetChild("PhoneNumberInput");
            CodeInput = (GTextInput)GetChild("CodeInput");
            close = (GButton)GetChild("close");
            Title = (GTextField)GetChild("Title");
            SubmitButton = (GButton)GetChild("SubmitButton");
            ObtainButton = (GButton)GetChild("ObtainButton");
        }
    }
}