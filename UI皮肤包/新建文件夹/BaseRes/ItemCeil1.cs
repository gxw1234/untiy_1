/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ItemCeil1 : GButton
    {
        public Controller button;
        public GGraph n0;
        public GGraph n1;
        public GGraph n2;
        public GImage pc;
        public GLoader PictureShow;
        public GTextField ItemName;
        public GTextField ItemPrice;
        public const string URL = "ui://use7blkky2clgvn2x5";

        public static ItemCeil1 CreateInstance()
        {
            return (ItemCeil1)UIPackage.CreateObject("BaseRes", "ItemCeil1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GGraph)GetChild("n0");
            n1 = (GGraph)GetChild("n1");
            n2 = (GGraph)GetChild("n2");
            pc = (GImage)GetChild("pc");
            PictureShow = (GLoader)GetChild("PictureShow");
            ItemName = (GTextField)GetChild("ItemName");
            ItemPrice = (GTextField)GetChild("ItemPrice");
        }
    }
}