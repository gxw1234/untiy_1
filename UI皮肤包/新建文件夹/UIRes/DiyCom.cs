/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DiyCom : GComponent
    {
        public GLoader Icon;
        public GTextField Title;
        public const string URL = "ui://jk0io98jmhay0";

        public static DiyCom CreateInstance()
        {
            return (DiyCom)UIPackage.CreateObject("UIRes", "DiyCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Icon = (GLoader)GetChild("Icon");
            Title = (GTextField)GetChild("Title");
        }
    }
}