/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DModelMenuItem6 : GButton
    {
        public Controller button;
        public GImage Img118cj7;
        public GImage Img1194jn;
        public const string URL = "ui://jk0io98jv9b1fs";

        public static DModelMenuItem6 CreateInstance()
        {
            return (DModelMenuItem6)UIPackage.CreateObject("UIRes", "DModelMenuItem6");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img118cj7 = (GImage)GetChild("Img118cj7");
            Img1194jn = (GImage)GetChild("Img1194jn");
        }
    }
}