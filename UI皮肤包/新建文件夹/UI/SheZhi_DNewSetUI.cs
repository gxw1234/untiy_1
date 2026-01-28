/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class SheZhi_DNewSetUI : GComponent
    {
        public Controller CPages;
        public GImage DState;
        public GComponent frame;
        public GButton DA2ETabButton5;
        public GButton DA2ETabButton4;
        public GButton DA2ETabButton3;
        public GButton DA2ETabButton2;
        public GButton DA2ETabButton1;
        public GButton DBtnStateColse;
        public GImage DA2EIMAGE9;
        public GGraph ModalLayer;
        public GComponent DA2EPage1;
        public GComponent DA2EPage2;
        public GComponent DA2EPage3;
        public GComponent DA2EPage4;
        public GComponent DA2EPage5;
        public GButton DBtnHelp;
        public const string URL = "ui://jyvofh5es46a0";

        public static SheZhi_DNewSetUI CreateInstance()
        {
            return (SheZhi_DNewSetUI)UIPackage.CreateObject("UI", "设置_DNewSetUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CPages = GetController("CPages");
            DState = (GImage)GetChild("DState");
            frame = (GComponent)GetChild("frame");
            DA2ETabButton5 = (GButton)GetChild("DA2ETabButton5");
            DA2ETabButton4 = (GButton)GetChild("DA2ETabButton4");
            DA2ETabButton3 = (GButton)GetChild("DA2ETabButton3");
            DA2ETabButton2 = (GButton)GetChild("DA2ETabButton2");
            DA2ETabButton1 = (GButton)GetChild("DA2ETabButton1");
            DBtnStateColse = (GButton)GetChild("DBtnStateColse");
            DA2EIMAGE9 = (GImage)GetChild("DA2EIMAGE9");
            ModalLayer = (GGraph)GetChild("ModalLayer");
            DA2EPage1 = (GComponent)GetChild("DA2EPage1");
            DA2EPage2 = (GComponent)GetChild("DA2EPage2");
            DA2EPage3 = (GComponent)GetChild("DA2EPage3");
            DA2EPage4 = (GComponent)GetChild("DA2EPage4");
            DA2EPage5 = (GComponent)GetChild("DA2EPage5");
            DBtnHelp = (GButton)GetChild("DBtnHelp");
        }
    }
}