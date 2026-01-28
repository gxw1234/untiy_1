/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class JiNengSheZhiPC_DSkillKeySetUI : GComponent
    {
        public Controller CRadios;
        public GImage n0;
        public GButton DCtrlF1;
        public GButton DCtrlF2;
        public GButton DCtrlF3;
        public GButton DCtrlF4;
        public GButton DCtrlF5;
        public GButton DCtrlF6;
        public GButton DCtrlF7;
        public GButton DCtrlF8;
        public GButton DF1;
        public GButton DF2;
        public GButton DF3;
        public GButton DF4;
        public GButton DF5;
        public GButton DF6;
        public GButton DF7;
        public GButton DF8;
        public GButton DNone;
        public GButton DBtnNo;
        public GTextField ChatEdit88;
        public GLoader GameSkillCell1;
        public const string URL = "ui://jyvofh5ewzbbmg";

        public static JiNengSheZhiPC_DSkillKeySetUI CreateInstance()
        {
            return (JiNengSheZhiPC_DSkillKeySetUI)UIPackage.CreateObject("UI", "技能设置PC_DSkillKeySetUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CRadios = GetController("CRadios");
            n0 = (GImage)GetChild("n0");
            DCtrlF1 = (GButton)GetChild("DCtrlF1");
            DCtrlF2 = (GButton)GetChild("DCtrlF2");
            DCtrlF3 = (GButton)GetChild("DCtrlF3");
            DCtrlF4 = (GButton)GetChild("DCtrlF4");
            DCtrlF5 = (GButton)GetChild("DCtrlF5");
            DCtrlF6 = (GButton)GetChild("DCtrlF6");
            DCtrlF7 = (GButton)GetChild("DCtrlF7");
            DCtrlF8 = (GButton)GetChild("DCtrlF8");
            DF1 = (GButton)GetChild("DF1");
            DF2 = (GButton)GetChild("DF2");
            DF3 = (GButton)GetChild("DF3");
            DF4 = (GButton)GetChild("DF4");
            DF5 = (GButton)GetChild("DF5");
            DF6 = (GButton)GetChild("DF6");
            DF7 = (GButton)GetChild("DF7");
            DF8 = (GButton)GetChild("DF8");
            DNone = (GButton)GetChild("DNone");
            DBtnNo = (GButton)GetChild("DBtnNo");
            ChatEdit88 = (GTextField)GetChild("ChatEdit88");
            GameSkillCell1 = (GLoader)GetChild("GameSkillCell1");
        }
    }
}