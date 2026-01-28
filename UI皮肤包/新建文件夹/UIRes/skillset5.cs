/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class skillset5 : GComponent
    {
        public GImage skillset5;
        public GLoader skill;
        public GTextField name;
        public const string URL = "ui://jk0io98jvv8k0";

        public static skillset5 CreateInstance()
        {
            return (skillset5)UIPackage.CreateObject("UIRes", "skillset5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skillset5 = (GImage)GetChild("skillset5");
            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
        }
    }
}