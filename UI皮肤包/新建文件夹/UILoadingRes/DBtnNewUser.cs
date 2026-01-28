/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnNewUser : GButton
    {
        public Controller button;
        public GImage Img371117;
        public GImage Img37263n;
        public const string URL = "ui://us2ut3jfr7r821";

        public static DBtnNewUser CreateInstance()
        {
            return (DBtnNewUser)UIPackage.CreateObject("UILoadingRes", "DBtnNewUser");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img371117 = (GImage)GetChild("Img371117");
            Img37263n = (GImage)GetChild("Img37263n");
        }
    }
}