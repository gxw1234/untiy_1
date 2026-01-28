/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DModelMenuItem0 : GButton
    {
        public Controller button;
        public GImage Img116c4e;
        public GImage Img117272;
        public const string URL = "ui://jk0io98jv9b1fm";

        public static DModelMenuItem0 CreateInstance()
        {
            return (DModelMenuItem0)UIPackage.CreateObject("UIRes", "DModelMenuItem0");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img116c4e = (GImage)GetChild("Img116c4e");
            Img117272 = (GImage)GetChild("Img117272");
        }
    }
}