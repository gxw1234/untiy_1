/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnOK : GButton
    {
        public Controller button;
        public GImage Img3467t;
        public GImage Img358m2;
        public const string URL = "ui://us2ut3jfr7r81i";

        public static DBtnOK CreateInstance()
        {
            return (DBtnOK)UIPackage.CreateObject("UILoadingRes", "DBtnOK");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img3467t = (GImage)GetChild("Img3467t");
            Img358m2 = (GImage)GetChild("Img358m2");
        }
    }
}