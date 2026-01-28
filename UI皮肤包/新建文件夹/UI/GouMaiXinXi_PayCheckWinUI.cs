/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class GouMaiXinXi_PayCheckWinUI : GComponent
    {
        public GImage n0;
        public GTextField n1;
        public GTextField n2;
        public GTextField DealMoNumTxt;
        public GTextField DealTimeTxt;
        public GButton PayTypeSBtn;
        public GButton BuyCloseBtn;
        public GList DealPayGrids;
        public const string URL = "ui://jyvofh5e11icn1pl";

        public static GouMaiXinXi_PayCheckWinUI CreateInstance()
        {
            return (GouMaiXinXi_PayCheckWinUI)UIPackage.CreateObject("UI", "购买信息_PayCheckWinUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            n1 = (GTextField)GetChild("n1");
            n2 = (GTextField)GetChild("n2");
            DealMoNumTxt = (GTextField)GetChild("DealMoNumTxt");
            DealTimeTxt = (GTextField)GetChild("DealTimeTxt");
            PayTypeSBtn = (GButton)GetChild("PayTypeSBtn");
            BuyCloseBtn = (GButton)GetChild("BuyCloseBtn");
            DealPayGrids = (GList)GetChild("DealPayGrids");
        }
    }
}