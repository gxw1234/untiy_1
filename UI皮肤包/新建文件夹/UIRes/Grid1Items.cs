/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Grid1Items : GComponent
    {
        public GTextField RoleName;
        public GTextField RoleJob;
        public GTextField RoleLevel;
        public GTextField RolePlay;
        public caozuo1 RoleLookBtn;
        public caozuo2 RoleBuyBtn;
        public const string URL = "ui://jk0io98jj3e21br";

        public static Grid1Items CreateInstance()
        {
            return (Grid1Items)UIPackage.CreateObject("UIRes", "Grid1Items");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            RoleName = (GTextField)GetChild("RoleName");
            RoleJob = (GTextField)GetChild("RoleJob");
            RoleLevel = (GTextField)GetChild("RoleLevel");
            RolePlay = (GTextField)GetChild("RolePlay");
            RoleLookBtn = (caozuo1)GetChild("RoleLookBtn");
            RoleBuyBtn = (caozuo2)GetChild("RoleBuyBtn");
        }
    }
}