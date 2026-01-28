/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page3 : GComponent
    {
        public GImage bg;
        public GTextField Txt1;
        public GTextField Txt2;
        public GTextField Txt3;
        public GTextField Txt4;
        public GTextField Txt5;
        public GTextField Txt6;
        public GList ListView;
        public const string URL = "ui://jk0io98jm9og1n";

        public static Page3 CreateInstance()
        {
            return (Page3)UIPackage.CreateObject("UIRes", "Page3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            Txt1 = (GTextField)GetChild("Txt1");
            Txt2 = (GTextField)GetChild("Txt2");
            Txt3 = (GTextField)GetChild("Txt3");
            Txt4 = (GTextField)GetChild("Txt4");
            Txt5 = (GTextField)GetChild("Txt5");
            Txt6 = (GTextField)GetChild("Txt6");
            ListView = (GList)GetChild("ListView");
        }
    }
}