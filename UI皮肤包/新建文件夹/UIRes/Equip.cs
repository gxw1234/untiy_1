/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Equip : GComponent
    {
        public GLoader role;
        public EquipCell0 EquipCell0;
        public EquipCell1 EquipCell1;
        public EquipCell16 EquipCell16;
        public EquipCell4 EquipCell4;
        public EquipCell13 EquipCell13;
        public const string URL = "ui://jk0io98jj3e21hl";

        public static Equip CreateInstance()
        {
            return (Equip)UIPackage.CreateObject("UIRes", "Equip");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            role = (GLoader)GetChild("role");
            EquipCell0 = (EquipCell0)GetChild("EquipCell0");
            EquipCell1 = (EquipCell1)GetChild("EquipCell1");
            EquipCell16 = (EquipCell16)GetChild("EquipCell16");
            EquipCell4 = (EquipCell4)GetChild("EquipCell4");
            EquipCell13 = (EquipCell13)GetChild("EquipCell13");
        }
    }
}