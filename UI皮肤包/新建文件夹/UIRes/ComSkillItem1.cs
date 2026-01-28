/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComSkillItem1 : GComponent
    {
        public ComSkillItem ComSkillItem;
        public const string URL = "ui://jk0io98jj4ky0";

        public static ComSkillItem1 CreateInstance()
        {
            return (ComSkillItem1)UIPackage.CreateObject("UIRes", "ComSkillItem1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            ComSkillItem = (ComSkillItem)GetChild("ComSkillItem");
        }
    }
}