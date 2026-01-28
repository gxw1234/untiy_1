/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DModelMenuItem3 : GButton
    {
        public Controller button;
        public GImage Img1200n2;
        public GImage Img12118h;
        public const string URL = "ui://jk0io98jv9b1fp";

        public static DModelMenuItem3 CreateInstance()
        {
            return (DModelMenuItem3)UIPackage.CreateObject("UIRes", "DModelMenuItem3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1200n2 = (GImage)GetChild("Img1200n2");
            Img12118h = (GImage)GetChild("Img12118h");
        }
    }
}