/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Button2 : GButton
    {
        public Controller button;
        public GImage n4;
        public GImage n5;
        public GTextField n7;
        public const string URL = "ui://jk0io98jj3e21bn";

        public static Button2 CreateInstance()
        {
            return (Button2)UIPackage.CreateObject("UIRes", "Button2");
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