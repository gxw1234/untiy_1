/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page2SellGoodsUI : GComponent
    {
        public GImage Page2SellGoodsUI;
        public GList DA2EGrid2;
        public GList DA2EGrid4;
        public const string URL = "ui://jk0io98jkn5z11z";

        public static Page2SellGoodsUI CreateInstance()
        {
            return (Page2SellGoodsUI)UIPackage.CreateObject("UIRes", "Page2SellGoodsUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Page2SellGoodsUI = (GImage)GetChild("Page2SellGoodsUI");
            DA2EGrid2 = (GList)GetChild("DA2EGrid2");
            DA2EGrid4 = (GList)GetChild("DA2EGrid4");
        }
    }
}