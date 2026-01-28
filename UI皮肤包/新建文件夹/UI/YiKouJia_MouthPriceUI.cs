/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class YiKouJia_MouthPriceUI : GComponent
    {
        public GImage MouthPriceUI;
        public GComponent frame;
        public GImage DA2EIMAGE5;
        public GImage DA2EIMAGE6;
        public GTextField PriceGoodsNames;
        public GTextField ChatEdit55;
        public GTextField ChatEdit56;
        public GComponent DA2EWindow19;
        public GComponent DA2EWindow20;
        public GButton MousePriceCancleBtn;
        public GButton MousePriceBuyBtn;
        public GComponent MousePriceGoods;
        public const string URL = "ui://jyvofh5ekn5z13m";

        public static YiKouJia_MouthPriceUI CreateInstance()
        {
            return (YiKouJia_MouthPriceUI)UIPackage.CreateObject("UI", "一口价_MouthPriceUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            MouthPriceUI = (GImage)GetChild("MouthPriceUI");
            frame = (GComponent)GetChild("frame");
            DA2EIMAGE5 = (GImage)GetChild("DA2EIMAGE5");
            DA2EIMAGE6 = (GImage)GetChild("DA2EIMAGE6");
            PriceGoodsNames = (GTextField)GetChild("PriceGoodsNames");
            ChatEdit55 = (GTextField)GetChild("ChatEdit55");
            ChatEdit56 = (GTextField)GetChild("ChatEdit56");
            DA2EWindow19 = (GComponent)GetChild("DA2EWindow19");
            DA2EWindow20 = (GComponent)GetChild("DA2EWindow20");
            MousePriceCancleBtn = (GButton)GetChild("MousePriceCancleBtn");
            MousePriceBuyBtn = (GButton)GetChild("MousePriceBuyBtn");
            MousePriceGoods = (GComponent)GetChild("MousePriceGoods");
        }
    }
}