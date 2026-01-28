/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class BtnBuy : GButton
    {
        public Controller button;
        public GGraph n0;
        public GGraph n1;
        public GGraph n2;
        public GLoader PictureShow;
        public GImage pc;
        public GTextField ItemName;
        public GTextField ItemPrice;
        public buyButton buyButton;
        public const string URL = "ui://use7blkky2clad";

        public static BtnBuy CreateInstance()
        {
            return (BtnBuy)UIPackage.CreateObject("BaseRes", "BtnBuy");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GGraph)GetChild("n0");
            n1 = (GGraph)GetChild("n1");
            n2 = (GGraph)GetChild("n2");
            PictureShow = (GLoader)GetChild("PictureShow");
            pc = (GImage)GetChild("pc");
            ItemName = (GTextField)GetChild("ItemName");
            ItemPrice = (GTextField)GetChild("ItemPrice");
            buyButton = (buyButton)GetChild("buyButton");
        }
    }
}