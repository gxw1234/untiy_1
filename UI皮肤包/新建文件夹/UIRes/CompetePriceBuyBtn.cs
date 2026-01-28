/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CompetePriceBuyBtn : GButton
    {
        public Controller button;
        public GImage Img265ewi;
        public GImage Img26665r;
        public GTextField CompetePricebutEdits;
        public const string URL = "ui://jk0io98jkn5z133";

        public static CompetePriceBuyBtn CreateInstance()
        {
            return (CompetePriceBuyBtn)UIPackage.CreateObject("UIRes", "CompetePriceBuyBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265ewi = (GImage)GetChild("Img265ewi");
            Img26665r = (GImage)GetChild("Img26665r");
            CompetePricebutEdits = (GTextField)GetChild("CompetePricebutEdits");
        }
    }
}