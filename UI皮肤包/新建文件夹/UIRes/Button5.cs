/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Button5 : GButton
    {
        public Controller button;
        public GImage n4;
        public GImage n5;
        public GTextField n7;
        public const string URL = "ui://jk0io98jg49um";

        public static Button5 CreateInstance()
        {
            return (Button5)UIPackage.CreateObject("UIRes", "Button5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n4 = (GImage)GetChild("n4");
            n5 = (GImage)GetChild("n5");
            n7 = (GTextField)GetChild("n7");
        }
    }
}