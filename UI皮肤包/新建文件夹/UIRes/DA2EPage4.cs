/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EPage4 : GComponent
    {
        public RoleAdvanWUI RoleAdvanWUI;
        public RolebaseWUI RolebaseWUI;
        public AbilityWinLJ AbilityWinLJ;
        public const string URL = "ui://jk0io98jw145b";

        public static DA2EPage4 CreateInstance()
        {
            return (DA2EPage4)UIPackage.CreateObject("UIRes", "DA2EPage4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            RoleAdvanWUI = (RoleAdvanWUI)GetChild("RoleAdvanWUI");
            RolebaseWUI = (RolebaseWUI)GetChild("RolebaseWUI");
            AbilityWinLJ = (AbilityWinLJ)GetChild("AbilityWinLJ");
        }
    }
}