/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoading
{
    public partial class XiuGaiMiMa_DChangePasswordUI : GComponent
    {
        public GImage DChangePasswordUI;
        public GTextInput DEditCPConfirm;
        public GTextInput DEditCPNewPasswd;
        public GTextInput DEditCPPasswd;
        public GTextInput DEditCPAccount;
        public GButton DBtnCPOK;
        public GButton DBtnCPFaill;
        public const string URL = "ui://up3anxyrr7r829";

        public static XiuGaiMiMa_DChangePasswordUI CreateInstance()
        {
            return (XiuGaiMiMa_DChangePasswordUI)UIPackage.CreateObject("UILoading", "修改密码_DChangePasswordUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DChangePasswordUI = (GImage)GetChild("DChangePasswordUI");
            DEditCPConfirm = (GTextInput)GetChild("DEditCPConfirm");
            DEditCPNewPasswd = (GTextInput)GetChild("DEditCPNewPasswd");
            DEditCPPasswd = (GTextInput)GetChild("DEditCPPasswd");
            DEditCPAccount = (GTextInput)GetChild("DEditCPAccount");
            DBtnCPOK = (GButton)GetChild("DBtnCPOK");
            DBtnCPFaill = (GButton)GetChild("DBtnCPFaill");
        }
    }
}