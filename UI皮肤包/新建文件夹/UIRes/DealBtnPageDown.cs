/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DealBtnPageDown : GButton
    {
        public Controller button;
        public GImage n4;
        public GImage n5;
        public const string URL = "ui://jk0io98jgcp1n1pt";

        public static DealBtnPageDown CreateInstance()
        {
            return (DealBtnPageDown)UIPackage.CreateObject("UIRes", "DealBtnPageDown");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n4 = (GImage)GetChild("n4");
            n5 = (GImage)GetChild("n5");
        }
    }
}