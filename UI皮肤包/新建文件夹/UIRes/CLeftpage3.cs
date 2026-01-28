/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CLeftpage3 : GComponent
    {
        public GImage n8;
        public GTextField n2;
        public GTextField n3;
        public GTextField n4;
        public GTextField n5;
        public GTextField n6;
        public GList GshelfGrids;
        public wenhao1 GSDealBtn;
        public GTextField n10;
        public GTextField GSJYBNumber;
        public DealBtnPageDown Page3BtnDown;
        public DealBtnPageUp Page3BtnUp;
        public const string URL = "ui://jk0io98jj3e21ce";

        public static CLeftpage3 CreateInstance()
        {
            return (CLeftpage3)UIPackage.CreateObject("UIRes", "CLeftpage3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n8 = (GImage)GetChild("n8");
            n2 = (GTextField)GetChild("n2");
            n3 = (GTextField)GetChild("n3");
            n4 = (GTextField)GetChild("n4");
            n5 = (GTextField)GetChild("n5");
            n6 = (GTextField)GetChild("n6");
            GshelfGrids = (GList)GetChild("GshelfGrids");
            GSDealBtn = (wenhao1)GetChild("GSDealBtn");
            n10 = (GTextField)GetChild("n10");
            GSJYBNumber = (GTextField)GetChild("GSJYBNumber");
            Page3BtnDown = (DealBtnPageDown)GetChild("Page3BtnDown");
            Page3BtnUp = (DealBtnPageUp)GetChild("Page3BtnUp");
        }
    }
}