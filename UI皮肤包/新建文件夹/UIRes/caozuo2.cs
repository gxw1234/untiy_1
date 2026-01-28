/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class caozuo2 : GButton
    {
        public Controller button;
        public GImage n4;
        public GImage n5;
        public GTextField n6;
        public const string URL = "ui://jk0io98jj3e21bt";

        public static caozuo2 CreateInstance()
        {
            return (caozuo2)UIPackage.CreateObject("UIRes", "caozuo2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n4 = (GImage)GetChild("n4");
            n5 = (GImage)GetChild("n5");
            n6 = (GTextField)GetChild("n6");
        }
    }
}