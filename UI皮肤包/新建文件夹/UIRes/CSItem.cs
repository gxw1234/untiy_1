/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CSItem : GComponent
    {
        public GGraph n1;
        public GLoader item;
        public GTextField ItemName;
        public GTextField Price;
        public GTextField shop;
        public GTextField leibie;
        public BackStorage BackStorage;
        public BuyButton BuyButton;
        public const string URL = "ui://jk0io98jm9og1i";

        public static CSItem CreateInstance()
        {
            return (CSItem)UIPackage.CreateObject("UIRes", "CSItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n1 = (GGraph)GetChild("n1");
            item = (GLoader)GetChild("item");
            ItemName = (GTextField)GetChild("ItemName");
            Price = (GTextField)GetChild("Price");
            shop = (GTextField)GetChild("shop");
            leibie = (GTextField)GetChild("leibie");
            BackStorage = (BackStorage)GetChild("BackStorage");
            BuyButton = (BuyButton)GetChild("BuyButton");
        }
    }
}