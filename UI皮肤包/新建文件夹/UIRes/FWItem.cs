/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class FWItem : GComponent
    {
        public GGraph bg;
        public GLoader item;
        public GTextField itemTxt;
        public GTextField Price;
        public GTextField leibie;
        public GTextField time;
        public BuyButton BuyButton;
        public const string URL = "ui://jk0io98jm9og1z";

        public static FWItem CreateInstance()
        {
            return (FWItem)UIPackage.CreateObject("UIRes", "FWItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GGraph)GetChild("bg");
            item = (GLoader)GetChild("item");
            itemTxt = (GTextField)GetChild("itemTxt");
            Price = (GTextField)GetChild("Price");
            leibie = (GTextField)GetChild("leibie");
            time = (GTextField)GetChild("time");
            BuyButton = (BuyButton)GetChild("BuyButton");
        }
    }
}