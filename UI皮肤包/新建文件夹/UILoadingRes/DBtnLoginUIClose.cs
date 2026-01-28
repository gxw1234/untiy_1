/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnLoginUIClose : GButton
    {
        public Controller button;
        public GImage Img0s43;
        public GImage Img1yrg;
        public const string URL = "ui://us2ut3jfr7r81z";

        public static DBtnLoginUIClose CreateInstance()
        {
            return (DBtnLoginUIClose)UIPackage.CreateObject("UILoadingRes", "DBtnLoginUIClose");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img0s43 = (GImage)GetChild("Img0s43");
            Img1yrg = (GImage)GetChild("Img1yrg");
        }
    }
}