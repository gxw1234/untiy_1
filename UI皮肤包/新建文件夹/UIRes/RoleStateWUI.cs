/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RoleStateWUI : GComponent
    {
        public GTextField RoleStateAttribEdit;
        public const string URL = "ui://jk0io98jj3e21ew";

        public static RoleStateWUI CreateInstance()
        {
            return (RoleStateWUI)UIPackage.CreateObject("UIRes", "RoleStateWUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            RoleStateAttribEdit = (GTextField)GetChild("RoleStateAttribEdit");
        }
    }
}