/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnCPOK : GButton
    {
        public Controller button;
        public GImage Img386488;
        public GImage Img387555;
        public const string URL = "ui://us2ut3jfr7r81k";

        public static DBtnCPOK CreateInstance()
        {
            return (DBtnCPOK)UIPackage.CreateObject("UILoadingRes", "DBtnCPOK");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img386488 = (GImage)GetChild("Img386488");
            Img387555 = (GImage)GetChild("Img387555");
        }
    }
}