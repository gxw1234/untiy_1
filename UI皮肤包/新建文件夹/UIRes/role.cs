/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class role : GComponent
    {
        public GLoader RRoleModerLoader;
        public EquipCell0 EquipCell0;
        public EquipCell4 EquipCell4;
        public EquipCell13 EquipCell13;
        public EquipCell1 EquipCell1;
        public EquipCell16 EquipCell16;
        public const string URL = "ui://jk0io98jkn5zzq";

        public static role CreateInstance()
        {
            return (role)UIPackage.CreateObject("UIRes", "role");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            RRoleModerLoader = (GLoader)GetChild("RRoleModerLoader");
            EquipCell0 = (EquipCell0)GetChild("EquipCell0");
            EquipCell4 = (EquipCell4)GetChild("EquipCell4");
            EquipCell13 = (EquipCell13)GetChild("EquipCell13");
            EquipCell1 = (EquipCell1)GetChild("EquipCell1");
            EquipCell16 = (EquipCell16)GetChild("EquipCell16");
        }
    }
}