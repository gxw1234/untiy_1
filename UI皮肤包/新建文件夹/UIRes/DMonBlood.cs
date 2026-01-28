/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DMonBlood : GProgressBar
    {
        public GImage bar;
        public GTextField title;
        public const string URL = "ui://jk0io98jv9b167";

        public static DMonBlood CreateInstance()
        {
            return (DMonBlood)UIPackage.CreateObject("UIRes", "DMonBlood");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bar = (GImage)GetChild("bar");
            title = (GTextField)GetChild("title");
        }
    }
}