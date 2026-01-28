/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnMission : GButton
    {
        public Controller button;
        public GImage Img2830l5;
        public GImage Img2834o8;
        public const string URL = "ui://jk0io98jj3e21oi";

        public static DBtnMission CreateInstance()
        {
            return (DBtnMission)UIPackage.CreateObject("UIRes", "DBtnMission");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2830l5 = (GImage)GetChild("Img2830l5");
            Img2834o8 = (GImage)GetChild("Img2834o8");
        }
    }
}