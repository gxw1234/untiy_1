/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class skill7 : GComponent
    {
        public GLoader skill;
        public GTextField name;
        public const string URL = "ui://jk0io98jwieq5";

        public static skill7 CreateInstance()
        {
            return (skill7)UIPackage.CreateObject("UIRes", "skill7");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
        }
    }
}