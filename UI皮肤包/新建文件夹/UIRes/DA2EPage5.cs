/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EPage5 : GComponent
    {
        public DA2EWindow12 title1;
        public GList SkillList;
        public DA2EWindow12 title2;
        public AdvancedCombatCom AdvancedCombatCom;
        public DA2EWindow12 title3;
        public GList SkillSetList;
        public Button7 btnReset;
        public const string URL = "ui://jk0io98js46a12";

        public static DA2EPage5 CreateInstance()
        {
            return (DA2EPage5)UIPackage.CreateObject("UIRes", "DA2EPage5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            title1 = (DA2EWindow12)GetChild("title1");
            SkillList = (GList)GetChild("SkillList");
            title2 = (DA2EWindow12)GetChild("title2");
            AdvancedCombatCom = (AdvancedCombatCom)GetChild("AdvancedCombatCom");
            title3 = (DA2EWindow12)GetChild("title3");
            SkillSetList = (GList)GetChild("SkillSetList");
            btnReset = (Button7)GetChild("btnReset");
        }
    }
}