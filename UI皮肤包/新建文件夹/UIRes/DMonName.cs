/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DMonName : GComponent
    {
        public GTextField title;
        public const string URL = "ui://jk0io98jv9b168";

        public static DMonName CreateInstance()
        {
            return (DMonName)UIPackage.CreateObject("UIRes", "DMonName");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            title = (GTextField)GetChild("title");
        }
    }
}