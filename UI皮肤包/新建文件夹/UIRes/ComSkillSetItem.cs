/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComSkillSetItem : GButton
    {
        public Controller button;
        public GImage bg;
        public GTextField title0;
        public GTextField title1;
        public GTextField skillname;
        public GTextInput input;
        public ComSkillSet2Item check;
        public const string URL = "ui://jk0io98jqu4p0";

        public static ComSkillSetItem CreateInstance()
        {
            return (ComSkillSetItem)UIPackage.CreateObject("UIRes", "ComSkillSetItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            bg = (GImage)GetChild("bg");
            title0 = (GTextField)GetChild("title0");
            title1 = (GTextField)GetChild("title1");
            skillname = (GTextField)GetChild("skillname");
            input = (GTextInput)GetChild("input");
            check = (ComSkillSet2Item)GetChild("check");
        }
    }
}