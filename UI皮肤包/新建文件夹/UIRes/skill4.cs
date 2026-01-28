/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class skill4 : GComponent
    {
        public GLoader skill;
        public GTextField name;
        public const string URL = "ui://jk0io98j870h1";

        public static skill4 CreateInstance()
        {
            return (skill4)UIPackage.CreateObject("UIRes", "skill4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
        }
    }
}