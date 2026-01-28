/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class GongHui_WinGuild_MainUI : GComponent
    {
        public Controller CPages;
        public GImage WinGuildUI;
        public GComponent frame;
        public GImage ImgGuild;
        public GButton BtnClose;
        public GButton TabBtnGuild;
        public GButton TabBtnMember;
        public GButton TabBtnDiplomacy;
        public GButton TabBtnApply;
        public GButton TabBtnLog;
        public GGraph ModalLayer;
        public GComponent DA2EPage1;
        public GComponent DA2EPage2;
        public GComponent DA2EPage3;
        public GComponent DA2EPage4;
        public GComponent DA2EPage5;
        public const string URL = "ui://jyvofh5ekn5z18i";

        public static GongHui_WinGuild_MainUI CreateInstance()
        {
            return (GongHui_WinGuild_MainUI)UIPackage.CreateObject("UI", "工会_WinGuild_MainUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CPages = GetController("CPages");
            WinGuildUI = (GImage)GetChild("WinGuildUI");
            frame = (GComponent)GetChild("frame");
            ImgGuild = (GImage)GetChild("ImgGuild");
            BtnClose = (GButton)GetChild("BtnClose");
            TabBtnGuild = (GButton)GetChild("TabBtnGuild");
            TabBtnMember = (GButton)GetChild("TabBtnMember");
            TabBtnDiplomacy = (GButton)GetChild("TabBtnDiplomacy");
            TabBtnApply = (GButton)GetChild("TabBtnApply");
            TabBtnLog = (GButton)GetChild("TabBtnLog");
            ModalLayer = (GGraph)GetChild("ModalLayer");
            DA2EPage1 = (GComponent)GetChild("DA2EPage1");
            DA2EPage2 = (GComponent)GetChild("DA2EPage2");
            DA2EPage3 = (GComponent)GetChild("DA2EPage3");
            DA2EPage4 = (GComponent)GetChild("DA2EPage4");
            DA2EPage5 = (GComponent)GetChild("DA2EPage5");
        }
    }
}