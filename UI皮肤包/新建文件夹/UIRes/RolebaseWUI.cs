/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RolebaseWUI : GComponent
    {
        public GTextField RoleAttribBasEdit;
        public const string URL = "ui://jk0io98jj3e21ez";

        public static RolebaseWUI CreateInstance()
        {
            return (RolebaseWUI)UIPackage.CreateObject("UIRes", "RolebaseWUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            RoleAttribBasEdit = (GTextField)GetChild("RoleAttribBasEdit");
        }
    }
}