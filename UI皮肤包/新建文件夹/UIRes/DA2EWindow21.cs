/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow21 : GComponent
    {
        public GImage DA2EWindow21;
        public GTextField CompeteNowPriceEdit;
        public const string URL = "ui://jk0io98jkn5z130";

        public static DA2EWindow21 CreateInstance()
        {
            return (DA2EWindow21)UIPackage.CreateObject("UIRes", "DA2EWindow21");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow21 = (GImage)GetChild("DA2EWindow21");
            CompeteNowPriceEdit = (GTextField)GetChild("CompeteNowPriceEdit");
        }
    }
}