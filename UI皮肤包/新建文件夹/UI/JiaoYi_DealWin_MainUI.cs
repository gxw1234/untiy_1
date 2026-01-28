/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class JiaoYi_DealWin_MainUI : GComponent
    {
        public Controller cpage;
        public GImage bg;
        public GComponent frame;
        public GGraph ModalLayer;
        public GButton DealCloseBtn;
        public GButton LeftRBtn1;
        public GButton LeftRBtn2;
        public GButton LeftRBtn3;
        public GComponent CLeftpage1;
        public GComponent CLeftpage2;
        public GComponent CLeftpage3;
        public const string URL = "ui://jyvofh5e11icn1pj";

        public static JiaoYi_DealWin_MainUI CreateInstance()
        {
            return (JiaoYi_DealWin_MainUI)UIPackage.CreateObject("UI", "交易_DealWin_MainUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            cpage = GetController("cpage");
            bg = (GImage)GetChild("bg");
            frame = (GComponent)GetChild("frame");
            ModalLayer = (GGraph)GetChild("ModalLayer");
            DealCloseBtn = (GButton)GetChild("DealCloseBtn");
            LeftRBtn1 = (GButton)GetChild("LeftRBtn1");
            LeftRBtn2 = (GButton)GetChild("LeftRBtn2");
            LeftRBtn3 = (GButton)GetChild("LeftRBtn3");
            CLeftpage1 = (GComponent)GetChild("CLeftpage1");
            CLeftpage2 = (GComponent)GetChild("CLeftpage2");
            CLeftpage3 = (GComponent)GetChild("CLeftpage3");
        }
    }
}