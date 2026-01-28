/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page2 : GComponent
    {
        public GImage bg;
        public GTextField Txt1;
        public GTextField Txt2;
        public GTextField Txt3;
        public GTextField Txt4;
        public GList ListView;
        public const string URL = "ui://jk0io98jm9og1k";

        public static Page2 CreateInstance()
        {
            return (Page2)UIPackage.CreateObject("UIRes", "Page2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            Txt1 = (GTextField)GetChild("Txt1");
            Txt2 = (GTextField)GetChild("Txt2");
            Txt3 = (GTextField)GetChild("Txt3");
            Txt4 = (GTextField)GetChild("Txt4");
            ListView = (GList)GetChild("ListView");
        }
    }
}