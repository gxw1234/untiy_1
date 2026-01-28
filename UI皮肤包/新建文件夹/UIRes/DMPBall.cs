/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DMPBall : GProgressBar
    {
        public GImage n0;
        public GImage bar;
        public GTextField title;
        public const string URL = "ui://jk0io98jiwgogvn2yf";

        public static DMPBall CreateInstance()
        {
            return (DMPBall)UIPackage.CreateObject("UIRes", "DMPBall");
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