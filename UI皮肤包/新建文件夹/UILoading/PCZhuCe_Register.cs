/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoading
{
    public partial class PCZhuCe_Register : GComponent
    {
        public GImage background;
        public GImage title4;
        public GImage title3;
        public GImage title2;
        public GImage title1;
        public GTextField UserID;
        public GTextField Code;
        public GTextField UserPassword;
        public GTextInput UserIDInput;
        public GTextInput UserPasswordInput;
        public GTextInput MobileInput;
        public GTextInput CodeInput;
        public GButton close;
        public GButton SubmitButton;
        public GButton ObtainButton;
        public GTextField Mobile;
        public GTextField Title;
        public const string URL = "ui://up3anxyrps2x4";

        public static PCZhuCe_Register CreateInstance()
        {
            return (PCZhuCe_Register)UIPackage.CreateObject("UILoading", "PC注册_Register");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            background = (GImage)GetChild("background");
            title4 = (GImage)GetChild("title4");
            title3 = (GImage)GetChild("title3");
            title2 = (GImage)GetChild("title2");
            title1 = (GImage)GetChild("title1");
            UserID = (GTextField)GetChild("UserID");
            Code = (GTextField)GetChild("Code");
            UserPassword = (GTextField)GetChild("UserPassword");
            UserIDInput = (GTextInput)GetChild("UserIDInput");
            UserPasswordInput = (GTextInput)GetChild("UserPasswordInput");
            MobileInput = (GTextInput)GetChild("MobileInput");
            CodeInput = (GTextInput)GetChild("CodeInput");
            close = (GButton)GetChild("close");
            SubmitButton = (GButton)GetChild("SubmitButton");
            ObtainButton = (GButton)GetChild("ObtainButton");
            Mobile = (GTextField)GetChild("Mobile");
            Title = (GTextField)GetChild("Title");
        }
    }
}