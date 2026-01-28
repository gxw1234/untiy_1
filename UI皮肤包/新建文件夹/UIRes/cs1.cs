/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class cs1 : GComponent
    {
        public GImage bg;
        public GList ListView;
        public GTextField txt1;
        public GTextField txt2;
        public GTextField txt3;
        public GTextField txt4;
        public GTextField txt5;
        public GTextField txt6;
        public const string URL = "ui://jk0io98jm9og1g";

        public static cs1 CreateInstance()
        {
            return (cs1)UIPackage.CreateObject("UIRes", "cs1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            ListView = (GList)GetChild("ListView");
            txt1 = (GTextField)GetChild("txt1");
            txt2 = (GTextField)GetChild("txt2");
            txt3 = (GTextField)GetChild("txt3");
            txt4 = (GTextField)GetChild("txt4");
            txt5 = (GTextField)GetChild("txt5");
            txt6 = (GTextField)GetChild("txt6");
        }
    }
}