/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class skillset8 : GComponent
    {
        public GImage skillset8;
        public GLoader skill;
        public GTextField name;
        public const string URL = "ui://jk0io98jes240";

        public static skillset8 CreateInstance()
        {
            return (skillset8)UIPackage.CreateObject("UIRes", "skillset8");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skillset8 = (GImage)GetChild("skillset8");
            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
        }
    }
}