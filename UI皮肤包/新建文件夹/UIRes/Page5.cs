/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page5 : GComponent
    {
        public GTextField Txt;
        public GImage n2;
        public const string URL = "ui://jk0io98jm9og1r";

        public static Page5 CreateInstance()
        {
            return (Page5)UIPackage.CreateObject("UIRes", "Page5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Txt = (GTextField)GetChild("Txt");
            n2 = (GImage)GetChild("n2");
        }
    }
}