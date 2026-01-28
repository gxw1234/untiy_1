/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page2Com : GComponent
    {
        public GImage n0;
        public GImage n11;
        public GImage n12;
        public GList MoneyGrids;
        public GTextField TGNameTxt;
        public GTextField TGroleTxt;
        public GTextField TGPlayTxt;
        public GRichTextField TGNumTxt;
        public GRichTextField TGPriceTxt;
        public const string URL = "ui://jk0io98jj3e21bu";

        public static Page2Com CreateInstance()
        {
            return (Page2Com)UIPackage.CreateObject("UIRes", "Page2Com");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            n11 = (GImage)GetChild("n11");
            n12 = (GImage)GetChild("n12");
            MoneyGrids = (GList)GetChild("MoneyGrids");
            TGNameTxt = (GTextField)GetChild("TGNameTxt");
            TGroleTxt = (GTextField)GetChild("TGroleTxt");
            TGPlayTxt = (GTextField)GetChild("TGPlayTxt");
            TGNumTxt = (GRichTextField)GetChild("TGNumTxt");
            TGPriceTxt = (GRichTextField)GetChild("TGPriceTxt");
        }
    }
}