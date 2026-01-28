/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DealRolePage1 : GComponent
    {
        public GTextField n0;
        public GTextField RoleNameTxt;
        public GTextField n2;
        public GTextField n3;
        public GImage n10;
        public GTextInput RoleTallTxt;
        public GTextField ServerchargeTxt;
        public GTextField n12;
        public GTextField n13;
        public GTextField n14;
        public GTextField n15;
        public GTextField n16;
        public GTextField n17;
        public GImage n18;
        public GImage n19;
        public GImage n20;
        public CreatImgBtn CreatImgBtn;
        public GTextField T_assign_title;
        public GImage n26;
        public GTextInput RoleAssignTxt;
        public GTextField T_assign_desc;
        public const string URL = "ui://jk0io98jj3e21c4";

        public static DealRolePage1 CreateInstance()
        {
            return (DealRolePage1)UIPackage.CreateObject("UIRes", "DealRolePage1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GTextField)GetChild("n0");
            RoleNameTxt = (GTextField)GetChild("RoleNameTxt");
            n2 = (GTextField)GetChild("n2");
            n3 = (GTextField)GetChild("n3");
            n10 = (GImage)GetChild("n10");
            RoleTallTxt = (GTextInput)GetChild("RoleTallTxt");
            ServerchargeTxt = (GTextField)GetChild("ServerchargeTxt");
            n12 = (GTextField)GetChild("n12");
            n13 = (GTextField)GetChild("n13");
            n14 = (GTextField)GetChild("n14");
            n15 = (GTextField)GetChild("n15");
            n16 = (GTextField)GetChild("n16");
            n17 = (GTextField)GetChild("n17");
            n18 = (GImage)GetChild("n18");
            n19 = (GImage)GetChild("n19");
            n20 = (GImage)GetChild("n20");
            CreatImgBtn = (CreatImgBtn)GetChild("CreatImgBtn");
            T_assign_title = (GTextField)GetChild("T_assign_title");
            n26 = (GImage)GetChild("n26");
            RoleAssignTxt = (GTextInput)GetChild("RoleAssignTxt");
            T_assign_desc = (GTextField)GetChild("T_assign_desc");
        }
    }
}