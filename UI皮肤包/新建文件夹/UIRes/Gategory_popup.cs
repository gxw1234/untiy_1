/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Gategory_popup : GComponent
    {
        public GGraph n0;
        public GList list;
        public const string URL = "ui://jk0io98jm9ogj";

        public static Gategory_popup CreateInstance()
        {
            return (Gategory_popup)UIPackage.CreateObject("UIRes", "Gategory_popup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GGraph)GetChild("n0");
            list = (GList)GetChild("list");
        }
    }
}