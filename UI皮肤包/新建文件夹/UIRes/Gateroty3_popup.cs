/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Gateroty3_popup : GComponent
    {
        public GGraph n0;
        public GList list;
        public const string URL = "ui://jk0io98jm9og1c";

        public static Gateroty3_popup CreateInstance()
        {
            return (Gateroty3_popup)UIPackage.CreateObject("UIRes", "Gateroty3_popup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GGraph)GetChild("n0");
            list = (GList)GetChild("list");
        }
    }
}