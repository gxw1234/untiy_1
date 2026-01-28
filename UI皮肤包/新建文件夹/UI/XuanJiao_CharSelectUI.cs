/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class XuanJiao_CharSelectUI : GComponent
    {
        public GImage CharSelectUI;
        public GLoader DModel1;
        public GLoader DModel2;
        public GButton DBtnSel1;
        public GButton DBtnSel2;
        public GButton DStart;
        public GButton DCreate;
        public GButton DDelete;
        public GButton DRecover;
        public GButton DBack;
        public GTextField DServerName;
        public GTextField DName1;
        public GTextField DLevel1;
        public GTextField DJob1;
        public GTextField DName2;
        public GTextField DLevel2;
        public GTextField DJob2;
        public GComponent Role1;
        public GComponent Role2;
        public GTextField RolesName;
        public GButton BackRoleBtn1;
        public GButton BackRoleBtn2;
        public const string URL = "ui://jyvofh5e3ctax";

        public static XuanJiao_CharSelectUI CreateInstance()
        {
            return (XuanJiao_CharSelectUI)UIPackage.CreateObject("UI", "选角_CharSelectUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CharSelectUI = (GImage)GetChild("CharSelectUI");
            DModel1 = (GLoader)GetChild("DModel1");
            DModel2 = (GLoader)GetChild("DModel2");
            DBtnSel1 = (GButton)GetChild("DBtnSel1");
            DBtnSel2 = (GButton)GetChild("DBtnSel2");
            DStart = (GButton)GetChild("DStart");
            DCreate = (GButton)GetChild("DCreate");
            DDelete = (GButton)GetChild("DDelete");
            DRecover = (GButton)GetChild("DRecover");
            DBack = (GButton)GetChild("DBack");
            DServerName = (GTextField)GetChild("DServerName");
            DName1 = (GTextField)GetChild("DName1");
            DLevel1 = (GTextField)GetChild("DLevel1");
            DJob1 = (GTextField)GetChild("DJob1");
            DName2 = (GTextField)GetChild("DName2");
            DLevel2 = (GTextField)GetChild("DLevel2");
            DJob2 = (GTextField)GetChild("DJob2");
            Role1 = (GComponent)GetChild("Role1");
            Role2 = (GComponent)GetChild("Role2");
            RolesName = (GTextField)GetChild("RolesName");
            BackRoleBtn1 = (GButton)GetChild("BackRoleBtn1");
            BackRoleBtn2 = (GButton)GetChild("BackRoleBtn2");
        }
    }
}