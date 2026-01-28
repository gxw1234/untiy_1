/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class skillset0 : GComponent
    {
        public GLoader skill;
        public GTextField name;
        public const string URL = "ui://jk0io98jj76bk";

        public static skillset0 CreateInstance()
        {
            return (skillset0)UIPackage.CreateObject("UIRes", "skillset0");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
        }
    }
}