/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class skill5 : GComponent
    {
        public GLoader skill;
        public GTextField name;
        public const string URL = "ui://jk0io98j8v0t8";

        public static skill5 CreateInstance()
        {
            return (skill5)UIPackage.CreateObject("UIRes", "skill5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
        }
    }
}