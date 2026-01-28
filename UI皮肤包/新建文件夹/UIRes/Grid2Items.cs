/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Grid2Items : GComponent
    {
        public GTextField GNamesTxt;
        public GTextField GRoleTxt;
        public GTextField GnumTxt;
        public GTextField GpriceTxt;
        public caozuo2 MoneyBuyBtn;
        public const string URL = "ui://jk0io98jj3e21bv";

        public static Grid2Items CreateInstance()
        {
            return (Grid2Items)UIPackage.CreateObject("UIRes", "Grid2Items");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            GNamesTxt = (GTextField)GetChild("GNamesTxt");
            GRoleTxt = (GTextField)GetChild("GRoleTxt");
            GnumTxt = (GTextField)GetChild("GnumTxt");
            GpriceTxt = (GTextField)GetChild("GpriceTxt");
            MoneyBuyBtn = (caozuo2)GetChild("MoneyBuyBtn");
        }
    }
}