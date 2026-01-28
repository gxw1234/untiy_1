/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class LeftRBtn2 : GButton
    {
        public Controller button;
        public GImage n6;
        public GImage n5;
        public const string URL = "ui://jk0io98jj3e21c0";

        public static LeftRBtn2 CreateInstance()
        {
            return (LeftRBtn2)UIPackage.CreateObject("UIRes", "LeftRBtn2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n6 = (GImage)GetChild("n6");
            n5 = (GImage)GetChild("n5");
        }
    }
}