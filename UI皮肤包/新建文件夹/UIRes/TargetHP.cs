/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TargetHP : GProgressBar
    {
        public GImage bar;
        public GTextField title;
        public const string URL = "ui://jk0io98js33616";

        public static TargetHP CreateInstance()
        {
            return (TargetHP)UIPackage.CreateObject("UIRes", "TargetHP");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bar = (GImage)GetChild("bar");
            title = (GTextField)GetChild("title");
        }
    }
}