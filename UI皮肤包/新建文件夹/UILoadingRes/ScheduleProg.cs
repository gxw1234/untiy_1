/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class ScheduleProg : GProgressBar
    {
        public GImage n0;
        public GImage bar;
        public GTextField title;
        public const string URL = "ui://us2ut3jfr7r83";

        public static ScheduleProg CreateInstance()
        {
            return (ScheduleProg)UIPackage.CreateObject("UILoadingRes", "ScheduleProg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            bar = (GImage)GetChild("bar");
            title = (GTextField)GetChild("title");
        }
    }
}