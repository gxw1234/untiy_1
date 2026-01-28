/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnBackToFlutter : GButton
    {
        public Controller button;
        public GImage Img265865;
        public GImage Img266l6v;
        public GTextField n2;
        public const string URL = "ui://us2ut3jfr7r81y";

        public static DBtnBackToFlutter CreateInstance()
        {
            return (DBtnBackToFlutter)UIPackage.CreateObject("UILoadingRes", "DBtnBackToFlutter");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265865 = (GImage)GetChild("Img265865");
            Img266l6v = (GImage)GetChild("Img266l6v");
            n2 = (GTextField)GetChild("n2");
        }
    }
}