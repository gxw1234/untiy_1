/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class TaRenJiaoSe_DStateUI : GComponent
    {
        public Controller CPages;
        public GImage DState;
        public GComponent frame;
        public GButton DA2ETabButton3;
        public GButton DA2ETabButton2;
        public GButton DA2ETabButton1;
        public GButton DBtnStateColse;
        public GRichTextField DUserName;
        public GComponent DA2EPage1;
        public GComponent DA2EPage2;
        public GComponent DA2EPage3;
        public GImage Panel1;
        public GTextField PanelItemTips;
        public const string URL = "ui://jyvofh5ej3e21jx";

        public static TaRenJiaoSe_DStateUI CreateInstance()
        {
            return (TaRenJiaoSe_DStateUI)UIPackage.CreateObject("UI", "他人角色_DStateUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CPages = GetController("CPages");
            DState = (GImage)GetChild("DState");
            frame = (GComponent)GetChild("frame");
            DA2ETabButton3 = (GButton)GetChild("DA2ETabButton3");
            DA2ETabButton2 = (GButton)GetChild("DA2ETabButton2");
            DA2ETabButton1 = (GButton)GetChild("DA2ETabButton1");
            DBtnStateColse = (GButton)GetChild("DBtnStateColse");
            DUserName = (GRichTextField)GetChild("DUserName");
            DA2EPage1 = (GComponent)GetChild("DA2EPage1");
            DA2EPage2 = (GComponent)GetChild("DA2EPage2");
            DA2EPage3 = (GComponent)GetChild("DA2EPage3");
            Panel1 = (GImage)GetChild("Panel1");
            PanelItemTips = (GTextField)GetChild("PanelItemTips");
        }
    }
}