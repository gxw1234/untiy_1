/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class skillset6 : GComponent
    {
        public GImage skillset6;
        public GLoader skill;
        public GTextField name;
        public const string URL = "ui://jk0io98jg0tk7";

        public static skillset6 CreateInstance()
        {
            return (skillset6)UIPackage.CreateObject("UIRes", "skillset6");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skillset6 = (GImage)GetChild("skillset6");
            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
        }
    }
}