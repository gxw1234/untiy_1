/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoading
{
    public partial class PCShiMingRenZheng_RealName : GComponent
    {
        public GImage background;
        public GImage title2;
        public GImage title1;
        public GTextField Title;
        public GTextField UserName;
        public GTextField CodeID;
        public GTextInput UserNameInput;
        public GTextInput CodeIDInput;
        public GButton SubmitButton;
        public GButton close;
        public const string URL = "ui://up3anxyrpfmg3z";

        public static PCShiMingRenZheng_RealName CreateInstance()
        {
            return (PCShiMingRenZheng_RealName)UIPackage.CreateObject("UILoading", "PC实名认证_RealName");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            background = (GImage)GetChild("background");
            title2 = (GImage)GetChild("title2");
            title1 = (GImage)GetChild("title1");
            Title = (GTextField)GetChild("Title");
            UserName = (GTextField)GetChild("UserName");
            CodeID = (GTextField)GetChild("CodeID");
            UserNameInput = (GTextInput)GetChild("UserNameInput");
            CodeIDInput = (GTextInput)GetChild("CodeIDInput");
            SubmitButton = (GButton)GetChild("SubmitButton");
            close = (GButton)GetChild("close");
        }
    }
}