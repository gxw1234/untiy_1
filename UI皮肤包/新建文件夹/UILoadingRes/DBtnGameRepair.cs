/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnGameRepair : GButton
    {
        public Controller button;
        public GImage Img382c8s;
        public GImage Img383238;
        public const string URL = "ui://us2ut3jfr7r81v";

        public static DBtnGameRepair CreateInstance()
        {
            return (DBtnGameRepair)UIPackage.CreateObject("UILoadingRes", "DBtnGameRepair");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img382c8s = (GImage)GetChild("Img382c8s");
            Img383238 = (GImage)GetChild("Img383238");
        }
    }
}