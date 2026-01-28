/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class skillset4 : GComponent
    {
        public GImage skillset4;
        public GLoader skill;
        public GTextField name;
        public const string URL = "ui://jk0io98jt45q8";

        public static skillset4 CreateInstance()
        {
            return (skillset4)UIPackage.CreateObject("UIRes", "skillset4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skillset4 = (GImage)GetChild("skillset4");
            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
        }
    }
}