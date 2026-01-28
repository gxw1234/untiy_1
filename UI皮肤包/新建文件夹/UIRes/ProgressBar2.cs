/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ProgressBar2 : GProgressBar
    {
        public GGraph n0;
        public GGraph bar;
        public const string URL = "ui://jk0io98jia18vn2ub";

        public static ProgressBar2 CreateInstance()
        {
            return (ProgressBar2)UIPackage.CreateObject("UIRes", "ProgressBar2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GGraph)GetChild("n0");
            bar = (GGraph)GetChild("bar");
        }
    }
}