/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottLTeamloods : GProgressBar
    {
        public GImage bar;
        public GTextField title;
        public const string URL = "ui://jk0io98jv9b195";

        public static BottLTeamloods CreateInstance()
        {
            return (BottLTeamloods)UIPackage.CreateObject("UIRes", "BottLTeamloods");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bar = (GImage)GetChild("bar");
            title = (GTextField)GetChild("title");
        }
    }
}