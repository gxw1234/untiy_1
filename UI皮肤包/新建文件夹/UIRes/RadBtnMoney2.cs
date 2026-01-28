/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RadBtnMoney2 : GButton
    {
        public Controller button;
        public GImage n4;
        public GImage n5;
        public const string URL = "ui://jk0io98jj3e21c3";

        public static RadBtnMoney2 CreateInstance()
        {
            return (RadBtnMoney2)UIPackage.CreateObject("UIRes", "RadBtnMoney2");
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