/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComSkillItem2 : GComponent
    {
        public ComSkillItem ComSkillItem;
        public ComDownBox2 ComDownBox2;
        public const string URL = "ui://jk0io98jj4ky4";

        public static ComSkillItem2 CreateInstance()
        {
            return (ComSkillItem2)UIPackage.CreateObject("UIRes", "ComSkillItem2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            ComSkillItem = (ComSkillItem)GetChild("ComSkillItem");
            ComDownBox2 = (ComDownBox2)GetChild("ComDownBox2");
        }
    }
}