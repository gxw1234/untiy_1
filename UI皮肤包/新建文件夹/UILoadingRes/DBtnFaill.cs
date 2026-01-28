/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnFaill : GButton
    {
        public Controller button;
        public GImage Img3756x5;
        public GImage Img3762gh;
        public const string URL = "ui://us2ut3jfr7r81j";

        public static DBtnFaill CreateInstance()
        {
            return (DBtnFaill)UIPackage.CreateObject("UILoadingRes", "DBtnFaill");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img3756x5 = (GImage)GetChild("Img3756x5");
            Img3762gh = (GImage)GetChild("Img3762gh");
        }
    }
}