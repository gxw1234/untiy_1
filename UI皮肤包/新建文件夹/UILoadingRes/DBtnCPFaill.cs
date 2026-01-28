/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnCPFaill : GButton
    {
        public Controller button;
        public GImage Img375id3;
        public GImage Img376012;
        public const string URL = "ui://us2ut3jfr7r827";

        public static DBtnCPFaill CreateInstance()
        {
            return (DBtnCPFaill)UIPackage.CreateObject("UILoadingRes", "DBtnCPFaill");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img375id3 = (GImage)GetChild("Img375id3");
            Img376012 = (GImage)GetChild("Img376012");
        }
    }
}