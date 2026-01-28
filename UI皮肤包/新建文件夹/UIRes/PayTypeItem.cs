/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class PayTypeItem : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public GImage n2;
        public GImage n3;
        public GImage n4;
        public GLoader MoneyLoader;
        public GTextField PayName;
        public const string URL = "ui://jk0io98jhg53vn2sd";

        public static PayTypeItem CreateInstance()
        {
            return (PayTypeItem)UIPackage.CreateObject("UIRes", "PayTypeItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
            n2 = (GImage)GetChild("n2");
            n3 = (GImage)GetChild("n3");
            n4 = (GImage)GetChild("n4");
            MoneyLoader = (GLoader)GetChild("MoneyLoader");
            PayName = (GTextField)GetChild("PayName");
        }
    }
}