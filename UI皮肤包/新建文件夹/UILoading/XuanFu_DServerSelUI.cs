/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoading
{
    public partial class XuanFu_DServerSelUI : GComponent
    {
        public GButton DBtnSwitchAccount;
        public GButton DBtnGameNotice;
        public GButton DBtnGameRepair;
        public GButton DBtnInGame;
        public GButton DBtnSwitchServer;
        public GTextField DCurrServerName;
        public GTextField DCurrServerText;
        public GButton DBtnBackToFlutter;
        public GButton DChPCBtn;
        public GButton DDpiBtn;
        public GRichTextField prvicaytips1;
        public GRichTextField prvicaytips_fuwu;
        public GRichTextField prvicaytips2;
        public GRichTextField prvicaytips_yinsi;
        public GLoader yinsibg;
        public GImage yinsiset;
        public GRichTextField banhao;
        public GImage StateImg1;
        public GImage StateImg2;
        public GImage StateImg3;
        public PCDengLu_LoginUI PC登录_LoginUI;
        public PCDengLu2_LoginUI2 PC登录2_LoginUI2;
        public PCZhongZhiMiMa_ResetPassword PC重置密码_ResetPassword;
        public PCZhuCe_Register PC注册_Register;
        public PCShiMingRenZheng_RealName PC实名认证_RealName;
        public PCSaoMaDengLu_ScanLogin PC扫码登录_ScanLogin;
        public const string URL = "ui://up3anxyrr7r82d";

        public static XuanFu_DServerSelUI CreateInstance()
        {
            return (XuanFu_DServerSelUI)UIPackage.CreateObject("UILoading", "选服_DServerSelUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBtnSwitchAccount = (GButton)GetChild("DBtnSwitchAccount");
            DBtnGameNotice = (GButton)GetChild("DBtnGameNotice");
            DBtnGameRepair = (GButton)GetChild("DBtnGameRepair");
            DBtnInGame = (GButton)GetChild("DBtnInGame");
            DBtnSwitchServer = (GButton)GetChild("DBtnSwitchServer");
            DCurrServerName = (GTextField)GetChild("DCurrServerName");
            DCurrServerText = (GTextField)GetChild("DCurrServerText");
            DBtnBackToFlutter = (GButton)GetChild("DBtnBackToFlutter");
            DChPCBtn = (GButton)GetChild("DChPCBtn");
            DDpiBtn = (GButton)GetChild("DDpiBtn");
            prvicaytips1 = (GRichTextField)GetChild("prvicaytips1");
            prvicaytips_fuwu = (GRichTextField)GetChild("prvicaytips_fuwu");
            prvicaytips2 = (GRichTextField)GetChild("prvicaytips2");
            prvicaytips_yinsi = (GRichTextField)GetChild("prvicaytips_yinsi");
            yinsibg = (GLoader)GetChild("yinsibg");
            yinsiset = (GImage)GetChild("yinsiset");
            banhao = (GRichTextField)GetChild("banhao");
            StateImg1 = (GImage)GetChild("StateImg1");
            StateImg2 = (GImage)GetChild("StateImg2");
            StateImg3 = (GImage)GetChild("StateImg3");
            PC登录_LoginUI = (PCDengLu_LoginUI)GetChild("PC登录_LoginUI");
            PC登录2_LoginUI2 = (PCDengLu2_LoginUI2)GetChild("PC登录2_LoginUI2");
            PC重置密码_ResetPassword = (PCZhongZhiMiMa_ResetPassword)GetChild("PC重置密码_ResetPassword");
            PC注册_Register = (PCZhuCe_Register)GetChild("PC注册_Register");
            PC实名认证_RealName = (PCShiMingRenZheng_RealName)GetChild("PC实名认证_RealName");
            PC扫码登录_ScanLogin = (PCSaoMaDengLu_ScanLogin)GetChild("PC扫码登录_ScanLogin");
        }
    }
}