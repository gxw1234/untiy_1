/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class JiaoSe_DStateUI : GComponent
    {
        public Controller CPages;
        public GImage DState;
        public GComponent frame;
        public GRichTextField DUserName;
        public GButton DBtnStateColse;
        public GButton DA2ETabButton1;
        public GButton DA2ETabButton2;
        public GButton DA2ETabButton3;
        public GButton DA2ETabButton4;
        public GButton DA2ETabButton5;
        public GButton DA2ETabButton6;
        public GComponent DA2EPage1;
        public GComponent DA2EPage2;
        public GComponent DA2EPage3;
        public GComponent DA2EPage4;
        public GComponent DA2EPage5;
        public GComponent DA2EPage6;
        public GImage Panel1;
        public GTextField PanelItemTips;
        public const string URL = "ui://jyvofh5ewzbbmh";

        public static JiaoSe_DStateUI CreateInstance()
        {
            return (JiaoSe_DStateUI)UIPackage.CreateObject("UI", "角色_DStateUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CPages = GetController("CPages");
            DState = (GImage)GetChild("DState");
            frame = (GComponent)GetChild("frame");
            DUserName = (GRichTextField)GetChild("DUserName");
            DBtnStateColse = (GButton)GetChild("DBtnStateColse");
            DA2ETabButton1 = (GButton)GetChild("DA2ETabButton1");
            DA2ETabButton2 = (GButton)GetChild("DA2ETabButton2");
            DA2ETabButton3 = (GButton)GetChild("DA2ETabButton3");
            DA2ETabButton4 = (GButton)GetChild("DA2ETabButton4");
            DA2ETabButton5 = (GButton)GetChild("DA2ETabButton5");
            DA2ETabButton6 = (GButton)GetChild("DA2ETabButton6");
            DA2EPage1 = (GComponent)GetChild("DA2EPage1");
            DA2EPage2 = (GComponent)GetChild("DA2EPage2");
            DA2EPage3 = (GComponent)GetChild("DA2EPage3");
            DA2EPage4 = (GComponent)GetChild("DA2EPage4");
            DA2EPage5 = (GComponent)GetChild("DA2EPage5");
            DA2EPage6 = (GComponent)GetChild("DA2EPage6");
            Panel1 = (GImage)GetChild("Panel1");
            PanelItemTips = (GTextField)GetChild("PanelItemTips");
        }
    }
}