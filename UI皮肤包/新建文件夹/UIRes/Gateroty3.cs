/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Gateroty3 : GComboBox
    {
        public Controller button;
        public GImage bg;
        public GImage n0;
        public GImage n1;
        public GTextField title;
        public const string URL = "ui://jk0io98jm9og1a";

        public static Gateroty3 CreateInstance()
        {
            return (Gateroty3)UIPackage.CreateObject("UIRes", "Gateroty3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            bg = (GImage)GetChild("bg");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
            title = (GTextField)GetChild("title");
        }
    }
}