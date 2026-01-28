/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class skill6 : GComponent
    {
        public GLoader skill;
        public GTextField name;
        public const string URL = "ui://jk0io98jq77rt";

        public static skill6 CreateInstance()
        {
            return (skill6)UIPackage.CreateObject("UIRes", "skill6");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
        }
    }
}