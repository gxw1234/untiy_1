/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottomDealBankBtn : GButton
    {
        public Controller button;
        public GImage n2;
        public GImage n3;
        public const string URL = "ui://jk0io98jk02tn1v1";

        public static BottomDealBankBtn CreateInstance()
        {
            return (BottomDealBankBtn)UIPackage.CreateObject("UIRes", "BottomDealBankBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n2 = (GImage)GetChild("n2");
            n3 = (GImage)GetChild("n3");
        }
    }
}