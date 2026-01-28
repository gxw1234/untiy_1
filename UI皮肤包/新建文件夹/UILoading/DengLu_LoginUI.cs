/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoading
{
    public partial class DengLu_LoginUI : GComponent
    {
        public GImage LoginUI;
        public GTextInput DEditPasswd;
        public GTextInput DEditAccount;
        public GButton DBtnLoginUIClose;
        public GButton DBtnLoginOK;
        public GButton DBtnNewUser;
        public GButton DBtnChangPasswd;
        public const string URL = "ui://up3anxyrr7r82e";

        public static DengLu_LoginUI CreateInstance()
        {
            return (DengLu_LoginUI)UIPackage.CreateObject("UILoading", "登录_LoginUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            LoginUI = (GImage)GetChild("LoginUI");
            DEditPasswd = (GTextInput)GetChild("DEditPasswd");
            DEditAccount = (GTextInput)GetChild("DEditAccount");
            DBtnLoginUIClose = (GButton)GetChild("DBtnLoginUIClose");
            DBtnLoginOK = (GButton)GetChild("DBtnLoginOK");
            DBtnNewUser = (GButton)GetChild("DBtnNewUser");
            DBtnChangPasswd = (GButton)GetChild("DBtnChangPasswd");
        }
    }
}