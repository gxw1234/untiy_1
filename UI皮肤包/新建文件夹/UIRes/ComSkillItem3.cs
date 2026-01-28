/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComSkillItem3 : GComponent
    {
        public ComSkill2Item ComSkillItem;
        public ComDownBox2 ComDownBox2;
        public GImage bg;
        public GTextInput SetValue;
        public GTextField title1;
        public const string URL = "ui://jk0io98jj4kyd";

        public static ComSkillItem3 CreateInstance()
        {
            return (ComSkillItem3)UIPackage.CreateObject("UIRes", "ComSkillItem3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            ComSkillItem = (ComSkill2Item)GetChild("ComSkillItem");
            ComDownBox2 = (ComDownBox2)GetChild("ComDownBox2");
            bg = (GImage)GetChild("bg");
            SetValue = (GTextInput)GetChild("SetValue");
            title1 = (GTextField)GetChild("title1");
        }
    }
}