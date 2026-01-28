/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ShopItem : GComponent
    {
        public ShopNameButton ShopNameButton;
        public GTextField host;
        public GTextField time;
        public GTextField num;
        public GTextField total;
        public GTextField state;
        public GTextField du;
        public const string URL = "ui://jk0io98jm9ogc";

        public static ShopItem CreateInstance()
        {
            return (ShopItem)UIPackage.CreateObject("UIRes", "ShopItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            ShopNameButton = (ShopNameButton)GetChild("ShopNameButton");
            host = (GTextField)GetChild("host");
            time = (GTextField)GetChild("time");
            num = (GTextField)GetChild("num");
            total = (GTextField)GetChild("total");
            state = (GTextField)GetChild("state");
            du = (GTextField)GetChild("du");
        }
    }
}