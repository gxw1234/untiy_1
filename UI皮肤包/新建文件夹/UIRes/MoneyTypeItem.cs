/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class MoneyTypeItem : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public GImage n2;
        public GImage n3;
        public GImage n4;
        public GLoader MoneyLoader;
        public GTextField MoneyName;
        public GTextField MoneyRatio;
        public GTextField MoneyInput;
        public const string URL = "ui://jk0io98jj3e21p7";

        public static MoneyTypeItem CreateInstance()
        {
            return (MoneyTypeItem)UIPackage.CreateObject("UIRes", "MoneyTypeItem");
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
            MoneyName = (GTextField)GetChild("MoneyName");
            MoneyRatio = (GTextField)GetChild("MoneyRatio");
            MoneyInput = (GTextField)GetChild("MoneyInput");
        }
    }
}