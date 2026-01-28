/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class LeftRBtn1 : GButton
    {
        public Controller button;
        public GImage n8;
        public GImage n7;
        public const string URL = "ui://jk0io98jj3e21by";

        public static LeftRBtn1 CreateInstance()
        {
            return (LeftRBtn1)UIPackage.CreateObject("UIRes", "LeftRBtn1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n8 = (GImage)GetChild("n8");
            n7 = (GImage)GetChild("n7");
        }
    }
}