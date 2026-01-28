/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class battery : GProgressBar
    {
        public GImage n0;
        public GImage bar;
        public const string URL = "ui://jk0io98jv9b11c";

        public static battery CreateInstance()
        {
            return (battery)UIPackage.CreateObject("UIRes", "battery");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            bar = (GImage)GetChild("bar");
        }
    }
}