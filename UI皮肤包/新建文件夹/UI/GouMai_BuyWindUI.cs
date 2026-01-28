/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class GouMai_BuyWindUI : GComponent
    {
        public GImage BuyWind;
        public GComponent frame;
        public GTextField BuyEdit;
        public GTextField BuyEditname;
        public GTextField EditBuyPrice;
        public GButton BtnBuy;
        public GList GridBuy;
        public GButton BtnBuyClose;
        public const string URL = "ui://jyvofh5ej3e21gj";

        public static GouMai_BuyWindUI CreateInstance()
        {
            return (GouMai_BuyWindUI)UIPackage.CreateObject("UI", "购买_BuyWindUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            BuyWind = (GImage)GetChild("BuyWind");
            frame = (GComponent)GetChild("frame");
            BuyEdit = (GTextField)GetChild("BuyEdit");
            BuyEditname = (GTextField)GetChild("BuyEditname");
            EditBuyPrice = (GTextField)GetChild("EditBuyPrice");
            BtnBuy = (GButton)GetChild("BtnBuy");
            GridBuy = (GList)GetChild("GridBuy");
            BtnBuyClose = (GButton)GetChild("BtnBuyClose");
        }
    }
}