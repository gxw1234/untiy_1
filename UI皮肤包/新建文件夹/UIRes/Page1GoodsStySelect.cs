/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page1GoodsStySelect : GComponent
    {
        public GImage Page1GoodsStySelect;
        public n2 n2;
        public const string URL = "ui://jk0io98jkn5z11i";

        public static Page1GoodsStySelect CreateInstance()
        {
            return (Page1GoodsStySelect)UIPackage.CreateObject("UIRes", "Page1GoodsStySelect");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Page1GoodsStySelect = (GImage)GetChild("Page1GoodsStySelect");
            n2 = (n2)GetChild("n2");
        }
    }
}