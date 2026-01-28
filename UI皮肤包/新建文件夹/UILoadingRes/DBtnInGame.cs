/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnInGame : GButton
    {
        public Controller button;
        public GImage Img384qvx;
        public GImage Img385y7p;
        public const string URL = "ui://us2ut3jfr7r81w";

        public static DBtnInGame CreateInstance()
        {
            return (DBtnInGame)UIPackage.CreateObject("UILoadingRes", "DBtnInGame");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img384qvx = (GImage)GetChild("Img384qvx");
            Img385y7p = (GImage)GetChild("Img385y7p");
        }
    }
}