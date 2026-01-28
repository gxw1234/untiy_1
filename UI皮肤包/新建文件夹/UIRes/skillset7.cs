/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class skillset7 : GComponent
    {
        public GImage skillset7;
        public GLoader skill;
        public GTextField name;
        public const string URL = "ui://jk0io98j350ck";

        public static skillset7 CreateInstance()
        {
            return (skillset7)UIPackage.CreateObject("UIRes", "skillset7");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skillset7 = (GImage)GetChild("skillset7");
            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
        }
    }
}