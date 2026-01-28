/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class EquipCell : GComponent
    {
        public GLoader item;
        public const string URL = "ui://jk0io98jm9og1t";

        public static EquipCell CreateInstance()
        {
            return (EquipCell)UIPackage.CreateObject("UIRes", "EquipCell");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            item = (GLoader)GetChild("item");
        }
    }
}