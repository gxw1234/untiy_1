/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ShangJia_PutAwayGoodUI : GComponent
    {
        public GImage PutAwayGoodUI;
        public GComponent frame;
        public GImage DA2EIMAGE1;
        public GImage DA2EIMAGE2;
        public GTextField PutAwayGoodNames;
        public GTextField ChatEdit35;
        public GTextField ChatEdit39;
        public GTextField ChatEdit40;
        public GComponent PutAwayStPriWin;
        public GComponent PutAwayMoPriWin;
        public GButton PutAwayCancleBtn;
        public GButton PutAwayBuyBtn;
        public GButton PutAwayStartPriceBtn;
        public GButton PutAwayMouseBtn;
        public GComponent PutAwayGoodWin;
        public GTextField ChatEdit35_2;
        public GComponent ComDownBox;
        public GComponent ComDownBox1;
        public const string URL = "ui://jyvofh5ekn5z13n";

        public static ShangJia_PutAwayGoodUI CreateInstance()
        {
            return (ShangJia_PutAwayGoodUI)UIPackage.CreateObject("UI", "上架_PutAwayGoodUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            PutAwayGoodUI = (GImage)GetChild("PutAwayGoodUI");
            frame = (GComponent)GetChild("frame");
            DA2EIMAGE1 = (GImage)GetChild("DA2EIMAGE1");
            DA2EIMAGE2 = (GImage)GetChild("DA2EIMAGE2");
            PutAwayGoodNames = (GTextField)GetChild("PutAwayGoodNames");
            ChatEdit35 = (GTextField)GetChild("ChatEdit35");
            ChatEdit39 = (GTextField)GetChild("ChatEdit39");
            ChatEdit40 = (GTextField)GetChild("ChatEdit40");
            PutAwayStPriWin = (GComponent)GetChild("PutAwayStPriWin");
            PutAwayMoPriWin = (GComponent)GetChild("PutAwayMoPriWin");
            PutAwayCancleBtn = (GButton)GetChild("PutAwayCancleBtn");
            PutAwayBuyBtn = (GButton)GetChild("PutAwayBuyBtn");
            PutAwayStartPriceBtn = (GButton)GetChild("PutAwayStartPriceBtn");
            PutAwayMouseBtn = (GButton)GetChild("PutAwayMouseBtn");
            PutAwayGoodWin = (GComponent)GetChild("PutAwayGoodWin");
            ChatEdit35_2 = (GTextField)GetChild("ChatEdit35");
            ComDownBox = (GComponent)GetChild("ComDownBox");
            ComDownBox1 = (GComponent)GetChild("ComDownBox1");
        }
    }
}