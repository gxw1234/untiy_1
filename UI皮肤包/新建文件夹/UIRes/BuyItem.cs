/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BuyItem : GComponent
    {
        public GGraph n1;
        public GLoader item;
        public GTextField ItemName;
        public GTextField Price;
        public GTextField shop;
        public GTextField shopName;
        public GTextField leibie;
        public BuyButton BuyButton;
        public const string URL = "ui://jk0io98jm9og13";

        public static BuyItem CreateInstance()
        {
            return (BuyItem)UIPackage.CreateObject("UIRes", "BuyItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n1 = (GGraph)GetChild("n1");
            item = (GLoader)GetChild("item");
            ItemName = (GTextField)GetChild("ItemName");
            Price = (GTextField)GetChild("Price");
            shop = (GTextField)GetChild("shop");
            shopName = (GTextField)GetChild("shopName");
            leibie = (GTextField)GetChild("leibie");
            BuyButton = (BuyButton)GetChild("BuyButton");
        }
    }
}