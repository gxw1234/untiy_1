/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CSItem3 : GComponent
    {
        public GGraph n1;
        public GLoader item;
        public GTextField ItemName;
        public GTextField Price;
        public GTextField leibie;
        public GTextField time;
        public BackStorage BackStorage;
        public BuyButton BuyButton;
        public const string URL = "ui://jk0io98jm9og1o";

        public static CSItem3 CreateInstance()
        {
            return (CSItem3)UIPackage.CreateObject("UIRes", "CSItem3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n1 = (GGraph)GetChild("n1");
            item = (GLoader)GetChild("item");
            ItemName = (GTextField)GetChild("ItemName");
            Price = (GTextField)GetChild("Price");
            leibie = (GTextField)GetChild("leibie");
            time = (GTextField)GetChild("time");
            BackStorage = (BackStorage)GetChild("BackStorage");
            BuyButton = (BuyButton)GetChild("BuyButton");
        }
    }
}