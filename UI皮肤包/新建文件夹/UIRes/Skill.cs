/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Skill : GComponent
    {
        public Controller c1;
        public Controller c2;
        public Controller c3;
        public GTextField n0;
        public ComSkillItem4 n1;
        public ComSkillItem4 n4;
        public GTextField n5;
        public ComSlide n6;
        public GTextField n7;
        public ComSkillItem4 n8;
        public ComSkillItem4 n9;
        public GTextField n10;
        public ComSkillItem4 n11;
        public ComSkillItem4 n12;
        public const string URL = "ui://jk0io98js336gvn2wi";

        public static Skill CreateInstance()
        {
            return (Skill)UIPackage.CreateObject("UIRes", "Skill");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            c1 = GetController("c1");
            c2 = GetController("c2");
            c3 = GetController("c3");
            n0 = (GTextField)GetChild("n0");
            n1 = (ComSkillItem4)GetChild("n1");
            n4 = (ComSkillItem4)GetChild("n4");
            n5 = (GTextField)GetChild("n5");
            n6 = (ComSlide)GetChild("n6");
            n7 = (GTextField)GetChild("n7");
            n8 = (ComSkillItem4)GetChild("n8");
            n9 = (ComSkillItem4)GetChild("n9");
            n10 = (GTextField)GetChild("n10");
            n11 = (ComSkillItem4)GetChild("n11");
            n12 = (ComSkillItem4)GetChild("n12");
        }
    }
}