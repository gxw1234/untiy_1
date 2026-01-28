/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CSItem2 : GComponent
    {
        public GGraph n1;
        public GLoader item;
        public GTextField ItemName;
        public GTextField Price;
        public GTextField shop;
        public GTextField time;
        public BuyButton BuyButton;
        public const string URL = "ui://jk0io98jm9og1m";

        public static CSItem2 CreateInstance()
        {
            return (CSItem2)UIPackage.CreateObject("UIRes", "CSItem2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n1 = (GGraph)GetChild("n1");
            item = (GLoader)GetChild("item");
            ItemName = (GTextField)GetChild("ItemName");
            Price = (GTextField)GetChild("Price");
            shop = (GTextField)GetChild("shop");
            time = (GTextField)GetChild("time");
            BuyButton = (BuyButton)GetChild("BuyButton");
        }
    }
}