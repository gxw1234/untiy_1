/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnGameNotice : GButton
    {
        public Controller button;
        public GImage Img380ra3;
        public GImage Img381x54;
        public const string URL = "ui://us2ut3jfr7r81u";

        public static DBtnGameNotice CreateInstance()
        {
            return (DBtnGameNotice)UIPackage.CreateObject("UILoadingRes", "DBtnGameNotice");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img380ra3 = (GImage)GetChild("Img380ra3");
            Img381x54 = (GImage)GetChild("Img381x54");
        }
    }
}