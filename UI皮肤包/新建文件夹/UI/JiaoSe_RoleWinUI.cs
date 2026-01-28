/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class JiaoSe_RoleWinUI : GComponent
    {
        public Controller CPages;
        public GImage bg;
        public GComponent frame;
        public GRichTextField DUserName;
        public GButton DBtnStateColse;
        public GButton RoleRidBtn1;
        public GButton RoleRidBtn2;
        public GButton RoleRidBtn3;
        public GButton RoleRidBtn4;
        public GButton RoleRidBtn5;
        public GButton RoleRidBtn6;
        public GButton RoleRidBtn7;
        public GButton RoleRidBtn8;
        public GComponent DA2EPage1;
        public GComponent DA2EPage2;
        public GComponent DA2EPage3;
        public GComponent DA2EPage4;
        public GComponent DA2EPage5;
        public GComponent DA2EPage6;
        public GComponent DA2EPage7;
        public GComponent DA2EPage8;
        public GImage Panel1;
        public GTextField PanelItemTips;
        public const string URL = "ui://jyvofh5e11icn1pm";

        public static JiaoSe_RoleWinUI CreateInstance()
        {
            return (JiaoSe_RoleWinUI)UIPackage.CreateObject("UI", "角色_RoleWinUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CPages = GetController("CPages");
            bg = (GImage)GetChild("bg");
            frame = (GComponent)GetChild("frame");
            DUserName = (GRichTextField)GetChild("DUserName");
            DBtnStateColse = (GButton)GetChild("DBtnStateColse");
            RoleRidBtn1 = (GButton)GetChild("RoleRidBtn1");
            RoleRidBtn2 = (GButton)GetChild("RoleRidBtn2");
            RoleRidBtn3 = (GButton)GetChild("RoleRidBtn3");
            RoleRidBtn4 = (GButton)GetChild("RoleRidBtn4");
            RoleRidBtn5 = (GButton)GetChild("RoleRidBtn5");
            RoleRidBtn6 = (GButton)GetChild("RoleRidBtn6");
            RoleRidBtn7 = (GButton)GetChild("RoleRidBtn7");
            RoleRidBtn8 = (GButton)GetChild("RoleRidBtn8");
            DA2EPage1 = (GComponent)GetChild("DA2EPage1");
            DA2EPage2 = (GComponent)GetChild("DA2EPage2");
            DA2EPage3 = (GComponent)GetChild("DA2EPage3");
            DA2EPage4 = (GComponent)GetChild("DA2EPage4");
            DA2EPage5 = (GComponent)GetChild("DA2EPage5");
            DA2EPage6 = (GComponent)GetChild("DA2EPage6");
            DA2EPage7 = (GComponent)GetChild("DA2EPage7");
            DA2EPage8 = (GComponent)GetChild("DA2EPage8");
            Panel1 = (GImage)GetChild("Panel1");
            PanelItemTips = (GTextField)GetChild("PanelItemTips");
        }
    }
}