/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow15 : GComponent
    {
        public GImage DA2EWindow15;
        public GTextField CompeteSellPriceEdit;
        public const string URL = "ui://jk0io98jkn5z134";

        public static DA2EWindow15 CreateInstance()
        {
            return (DA2EWindow15)UIPackage.CreateObject("UIRes", "DA2EWindow15");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow15 = (GImage)GetChild("DA2EWindow15");
            CompeteSellPriceEdit = (GTextField)GetChild("CompeteSellPriceEdit");
        }
    }
}