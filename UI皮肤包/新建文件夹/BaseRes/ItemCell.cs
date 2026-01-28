/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ItemCell : GButton
    {
        public Controller button;
        public GImage Img186l15;
        public GTextField EditItemInfo;
        public GTextField EditCostInfo;
        public GTextField EditLastingInfo;
        public const string URL = "ui://use7blkkqgn28z";

        public static ItemCell CreateInstance()
        {
            return (ItemCell)UIPackage.CreateObject("BaseRes", "ItemCell");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img186l15 = (GImage)GetChild("Img186l15");
            EditItemInfo = (GTextField)GetChild("EditItemInfo");
            EditCostInfo = (GTextField)GetChild("EditCostInfo");
            EditLastingInfo = (GTextField)GetChild("EditLastingInfo");
        }
    }
}