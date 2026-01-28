/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page1RoleStySelect : GComponent
    {
        public GImage Page1RoleStySelect;
        public n1 n1;
        public const string URL = "ui://jk0io98jkn5z11g";

        public static Page1RoleStySelect CreateInstance()
        {
            return (Page1RoleStySelect)UIPackage.CreateObject("UIRes", "Page1RoleStySelect");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Page1RoleStySelect = (GImage)GetChild("Page1RoleStySelect");
            n1 = (n1)GetChild("n1");
        }
    }
}