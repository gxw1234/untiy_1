/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnLoginOK : GButton
    {
        public Controller button;
        public GImage Img3738p4;
        public GImage Img374o5l;
        public const string URL = "ui://us2ut3jfr7r820";

        public static DBtnLoginOK CreateInstance()
        {
            return (DBtnLoginOK)UIPackage.CreateObject("UILoadingRes", "DBtnLoginOK");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img3738p4 = (GImage)GetChild("Img3738p4");
            Img374o5l = (GImage)GetChild("Img374o5l");
        }
    }
}