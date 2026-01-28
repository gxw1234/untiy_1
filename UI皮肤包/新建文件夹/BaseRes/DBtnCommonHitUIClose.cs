/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DBtnCommonHitUIClose : GButton
    {
        public Controller button;
        public GImage Img066s;
        public GImage Img1o7g;
        public const string URL = "ui://use7blkkqgn26v";

        public static DBtnCommonHitUIClose CreateInstance()
        {
            return (DBtnCommonHitUIClose)UIPackage.CreateObject("BaseRes", "DBtnCommonHitUIClose");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img066s = (GImage)GetChild("Img066s");
            Img1o7g = (GImage)GetChild("Img1o7g");
        }
    }
}