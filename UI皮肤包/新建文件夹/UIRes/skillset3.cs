/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class skillset3 : GComponent
    {
        public GImage skillset3;
        public GLoader skill;
        public GTextField name;
        public const string URL = "ui://jk0io98j6g5cc";

        public static skillset3 CreateInstance()
        {
            return (skillset3)UIPackage.CreateObject("UIRes", "skillset3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skillset3 = (GImage)GetChild("skillset3");
            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
        }
    }
}