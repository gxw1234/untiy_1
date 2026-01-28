/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class JingPai_CompetePriceUI : GComponent
    {
        public GImage CompetePriceUI;
        public GComponent frame;
        public GImage DA2EIMAGE8;
        public GImage DA2EIMAGE9;
        public GTextField CompetePriceGoodsName;
        public GTextField ChatEdit53;
        public GTextField ChatEdit54;
        public GComponent DA2EWindow21;
        public GComponent DA2EWindow22;
        public GButton CompetePriceCancleBtn;
        public GButton CompetePriceBuyBtn;
        public GImage DA2EIMAGE11;
        public GTextField ChatEdit61;
        public GComponent DA2EWindow15;
        public GButton CompeteAddPriceEditBtn;
        public GComponent CompetePriceGoodsWins;
        public GLoader DA2ELoader71;
        public GLoader DA2ELoader72;
        public GLoader DA2ELoader73;
        public const string URL = "ui://jyvofh5ekn5z13g";

        public static JingPai_CompetePriceUI CreateInstance()
        {
            return (JingPai_CompetePriceUI)UIPackage.CreateObject("UI", "竞拍_CompetePriceUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CompetePriceUI = (GImage)GetChild("CompetePriceUI");
            frame = (GComponent)GetChild("frame");
            DA2EIMAGE8 = (GImage)GetChild("DA2EIMAGE8");
            DA2EIMAGE9 = (GImage)GetChild("DA2EIMAGE9");
            CompetePriceGoodsName = (GTextField)GetChild("CompetePriceGoodsName");
            ChatEdit53 = (GTextField)GetChild("ChatEdit53");
            ChatEdit54 = (GTextField)GetChild("ChatEdit54");
            DA2EWindow21 = (GComponent)GetChild("DA2EWindow21");
            DA2EWindow22 = (GComponent)GetChild("DA2EWindow22");
            CompetePriceCancleBtn = (GButton)GetChild("CompetePriceCancleBtn");
            CompetePriceBuyBtn = (GButton)GetChild("CompetePriceBuyBtn");
            DA2EIMAGE11 = (GImage)GetChild("DA2EIMAGE11");
            ChatEdit61 = (GTextField)GetChild("ChatEdit61");
            DA2EWindow15 = (GComponent)GetChild("DA2EWindow15");
            CompeteAddPriceEditBtn = (GButton)GetChild("CompeteAddPriceEditBtn");
            CompetePriceGoodsWins = (GComponent)GetChild("CompetePriceGoodsWins");
            DA2ELoader71 = (GLoader)GetChild("DA2ELoader71");
            DA2ELoader72 = (GLoader)GetChild("DA2ELoader72");
            DA2ELoader73 = (GLoader)GetChild("DA2ELoader73");
        }
    }
}