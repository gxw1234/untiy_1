/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class caozuo1 : GButton
    {
        public Controller button;
        public GImage n2;
        public GImage n3;
        public GTextField n4;
        public const string URL = "ui://jk0io98jj3e21bs";

        public static caozuo1 CreateInstance()
        {
            return (caozuo1)UIPackage.CreateObject("UIRes", "caozuo1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n2 = (GImage)GetChild("n2");
            n3 = (GImage)GetChild("n3");
            n4 = (GTextField)GetChild("n4");
        }
    }
}