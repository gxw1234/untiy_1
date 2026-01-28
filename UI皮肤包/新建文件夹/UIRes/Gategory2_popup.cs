/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Gategory2_popup : GComponent
    {
        public GGraph n0;
        public GList list;
        public const string URL = "ui://jk0io98jm9og17";

        public static Gategory2_popup CreateInstance()
        {
            return (Gategory2_popup)UIPackage.CreateObject("UIRes", "Gategory2_popup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GGraph)GetChild("n0");
            list = (GList)GetChild("list");
        }
    }
}