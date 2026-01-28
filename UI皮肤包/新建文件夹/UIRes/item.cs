/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class item : GComponent
    {
        public GGraph icon;
        public const string URL = "ui://jk0io98jruoyn2r5";

        public static item CreateInstance()
        {
            return (item)UIPackage.CreateObject("UIRes", "item");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            icon = (GGraph)GetChild("icon");
        }
    }
}