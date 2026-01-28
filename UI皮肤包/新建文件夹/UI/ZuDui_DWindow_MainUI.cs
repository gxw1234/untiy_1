/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ZuDui_DWindow_MainUI : GComponent
    {
        public Controller CPages;
        public GImage DWindow1;
        public GComponent frame;
        public GImage DA2EIMAGE1;
        public GButton DGroupApply;
        public GButton DMyGroup;
        public GButton DNearbyPeople;
        public GButton DNearbyGroup;
        public GButton DCloseBtn;
        public GComponent DA2EWindow1;
        public GGraph ModalLayer;
        public GComponent DA2EPage1;
        public GComponent DA2EPage2;
        public GComponent DA2EPage3;
        public GComponent DA2EPage4;
        public const string URL = "ui://jyvofh5e10awvn2rw";

        public static ZuDui_DWindow_MainUI CreateInstance()
        {
            return (ZuDui_DWindow_MainUI)UIPackage.CreateObject("UI", "组队_DWindow_MainUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CPages = GetController("CPages");
            DWindow1 = (GImage)GetChild("DWindow1");
            frame = (GComponent)GetChild("frame");
            DA2EIMAGE1 = (GImage)GetChild("DA2EIMAGE1");
            DGroupApply = (GButton)GetChild("DGroupApply");
            DMyGroup = (GButton)GetChild("DMyGroup");
            DNearbyPeople = (GButton)GetChild("DNearbyPeople");
            DNearbyGroup = (GButton)GetChild("DNearbyGroup");
            DCloseBtn = (GButton)GetChild("DCloseBtn");
            DA2EWindow1 = (GComponent)GetChild("DA2EWindow1");
            ModalLayer = (GGraph)GetChild("ModalLayer");
            DA2EPage1 = (GComponent)GetChild("DA2EPage1");
            DA2EPage2 = (GComponent)GetChild("DA2EPage2");
            DA2EPage3 = (GComponent)GetChild("DA2EPage3");
            DA2EPage4 = (GComponent)GetChild("DA2EPage4");
        }
    }
}