/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class skillset1 : GComponent
    {
        public GImage skillset1;
        public GLoader skill;
        public GTextField name;
        public const string URL = "ui://jk0io98j4o7ww";

        public static skillset1 CreateInstance()
        {
            return (skillset1)UIPackage.CreateObject("UIRes", "skillset1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skillset1 = (GImage)GetChild("skillset1");
            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
        }
    }
}