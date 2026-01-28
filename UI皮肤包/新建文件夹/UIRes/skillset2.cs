/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class skillset2 : GComponent
    {
        public GImage skillset2;
        public GLoader skill;
        public GTextField name;
        public const string URL = "ui://jk0io98joisxx";

        public static skillset2 CreateInstance()
        {
            return (skillset2)UIPackage.CreateObject("UIRes", "skillset2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skillset2 = (GImage)GetChild("skillset2");
            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
        }
    }
}