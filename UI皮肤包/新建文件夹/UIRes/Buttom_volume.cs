/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Buttom_volume : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public GImage n2;
        public GImage n3;
        public const string URL = "ui://jk0io98jiefvgvn2x4";

        public static Buttom_volume CreateInstance()
        {
            return (Buttom_volume)UIPackage.CreateObject("UIRes", "Buttom_volume");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
            n2 = (GImage)GetChild("n2");
            n3 = (GImage)GetChild("n3");
        }
    }
}