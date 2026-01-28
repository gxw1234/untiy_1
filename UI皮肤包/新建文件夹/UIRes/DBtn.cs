/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtn : GButton
    {
        public Controller button;
        public GImage Img31737h;
        public GImage Img318u3u;
        public const string URL = "ui://jk0io98jj3e21kf";

        public static DBtn CreateInstance()
        {
            return (DBtn)UIPackage.CreateObject("UIRes", "DBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img31737h = (GImage)GetChild("Img31737h");
            Img318u3u = (GImage)GetChild("Img318u3u");
        }
    }
}