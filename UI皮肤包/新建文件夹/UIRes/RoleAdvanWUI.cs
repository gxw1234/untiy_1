/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RoleAdvanWUI : GComponent
    {
        public GTextField RoleAttribAdvanEdit;
        public const string URL = "ui://jk0io98jj3e21ey";

        public static RoleAdvanWUI CreateInstance()
        {
            return (RoleAdvanWUI)UIPackage.CreateObject("UIRes", "RoleAdvanWUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            RoleAttribAdvanEdit = (GTextField)GetChild("RoleAttribAdvanEdit");
        }
    }
}