/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page1Com : GComponent
    {
        public GImage n8;
        public GImage n12;
        public GImage n13;
        public GImage n14;
        public GList RoleGrids;
        public GTextField n3;
        public GTextField n7;
        public GRichTextField TRoleJob;
        public GRichTextField TRoleLevel;
        public GRichTextField TRoleprice;
        public const string URL = "ui://jk0io98jj3e21bq";

        public static Page1Com CreateInstance()
        {
            return (Page1Com)UIPackage.CreateObject("UIRes", "Page1Com");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n8 = (GImage)GetChild("n8");
            n12 = (GImage)GetChild("n12");
            n13 = (GImage)GetChild("n13");
            n14 = (GImage)GetChild("n14");
            RoleGrids = (GList)GetChild("RoleGrids");
            n3 = (GTextField)GetChild("n3");
            n7 = (GTextField)GetChild("n7");
            TRoleJob = (GRichTextField)GetChild("TRoleJob");
            TRoleLevel = (GRichTextField)GetChild("TRoleLevel");
            TRoleprice = (GRichTextField)GetChild("TRoleprice");
        }
    }
}