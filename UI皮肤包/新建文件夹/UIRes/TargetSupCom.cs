/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TargetSupCom : GComponent
    {
        public Controller TargetSupComCon;
        public GTextField title;
        public ComSkillItem4 n1;
        public ComSkillItem4 n2;
        public ComSkillItem4 n4;
        public Button7 SetActorList;
        public Button7 SetSkillList;
        public ComBtnChoice SetFilterSkillBtn;
        public const string URL = "ui://jk0io98js336gvn2wj";

        public static TargetSupCom CreateInstance()
        {
            return (TargetSupCom)UIPackage.CreateObject("UIRes", "TargetSupCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            TargetSupComCon = GetController("TargetSupComCon");
            title = (GTextField)GetChild("title");
            n1 = (ComSkillItem4)GetChild("n1");
            n2 = (ComSkillItem4)GetChild("n2");
            n4 = (ComSkillItem4)GetChild("n4");
            SetActorList = (Button7)GetChild("SetActorList");
            SetSkillList = (Button7)GetChild("SetSkillList");
            SetFilterSkillBtn = (ComBtnChoice)GetChild("SetFilterSkillBtn");
        }
    }
}