/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class AdvancedCombatCom : GComponent
    {
        public TargetSupCom TargetSupCom;
        public Skill TrochalSet;
        public GRichTextField n4;
        public ComBtnChoice n6;
        public GTextInput checkDistance;
        public ComSkillItem btnSustainSkill;
        public const string URL = "ui://jk0io98js336gvn2wf";

        public static AdvancedCombatCom CreateInstance()
        {
            return (AdvancedCombatCom)UIPackage.CreateObject("UIRes", "AdvancedCombatCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            TargetSupCom = (TargetSupCom)GetChild("TargetSupCom");
            TrochalSet = (Skill)GetChild("TrochalSet");
            n4 = (GRichTextField)GetChild("n4");
            n6 = (ComBtnChoice)GetChild("n6");
            checkDistance = (GTextInput)GetChild("checkDistance");
            btnSustainSkill = (ComSkillItem)GetChild("btnSustainSkill");
        }
    }
}