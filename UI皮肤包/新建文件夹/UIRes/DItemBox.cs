/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DItemBox : GComponent
    {
        public GLoader ItemBoxCell;
        public GLoader ItemBoxCell1;
        public const string URL = "ui://jk0io98jhdg7vn2sp";

        public static DItemBox CreateInstance()
        {
            return (DItemBox)UIPackage.CreateObject("UIRes", "DItemBox");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            ItemBoxCell = (GLoader)GetChild("ItemBoxCell");
            ItemBoxCell1 = (GLoader)GetChild("ItemBoxCell1");
        }
    }
}