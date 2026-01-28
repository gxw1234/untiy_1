/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RadBtnMoney1 : GButton
    {
        public Controller button;
        public GImage n4;
        public GImage n5;
        public const string URL = "ui://jk0io98jj3e21c2";

        public static RadBtnMoney1 CreateInstance()
        {
            return (RadBtnMoney1)UIPackage.CreateObject("UIRes", "RadBtnMoney1");
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