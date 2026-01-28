/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class JiNengSheZhi_DSkillConfigUI : GComponent
    {
        public GImage DSkillConfig;
        public GComponent frame;
        public GComponent skillset0;
        public GTextField ChatEdit45;
        public GComponent skill0;
        public GComponent skill1;
        public GComponent skill2;
        public GComponent skill3;
        public GComponent skill4;
        public GComponent skill5;
        public GComponent skill6;
        public GComponent skill7;
        public GComponent skill8;
        public GComponent skillset1;
        public GComponent skillset2;
        public GComponent skillset3;
        public GComponent skillset4;
        public GComponent skillset5;
        public GComponent skillset6;
        public GComponent skillset7;
        public GComponent skillset8;
        public GButton closeButton;
        public GButton BtnPageDown;
        public GButton BtnPageUp;
        public GTextField page;
        public const string URL = "ui://jyvofh5ewzbbme";

        public static JiNengSheZhi_DSkillConfigUI CreateInstance()
        {
            return (JiNengSheZhi_DSkillConfigUI)UIPackage.CreateObject("UI", "技能设置_DSkillConfigUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DSkillConfig = (GImage)GetChild("DSkillConfig");
            frame = (GComponent)GetChild("frame");
            skillset0 = (GComponent)GetChild("skillset0");
            ChatEdit45 = (GTextField)GetChild("ChatEdit45");
            skill0 = (GComponent)GetChild("skill0");
            skill1 = (GComponent)GetChild("skill1");
            skill2 = (GComponent)GetChild("skill2");
            skill3 = (GComponent)GetChild("skill3");
            skill4 = (GComponent)GetChild("skill4");
            skill5 = (GComponent)GetChild("skill5");
            skill6 = (GComponent)GetChild("skill6");
            skill7 = (GComponent)GetChild("skill7");
            skill8 = (GComponent)GetChild("skill8");
            skillset1 = (GComponent)GetChild("skillset1");
            skillset2 = (GComponent)GetChild("skillset2");
            skillset3 = (GComponent)GetChild("skillset3");
            skillset4 = (GComponent)GetChild("skillset4");
            skillset5 = (GComponent)GetChild("skillset5");
            skillset6 = (GComponent)GetChild("skillset6");
            skillset7 = (GComponent)GetChild("skillset7");
            skillset8 = (GComponent)GetChild("skillset8");
            closeButton = (GButton)GetChild("closeButton");
            BtnPageDown = (GButton)GetChild("BtnPageDown");
            BtnPageUp = (GButton)GetChild("BtnPageUp");
            page = (GTextField)GetChild("page");
        }
    }
}