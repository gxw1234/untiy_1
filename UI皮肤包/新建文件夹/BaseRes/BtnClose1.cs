/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class BtnClose1 : GButton
    {
        public Controller button;
        public GImage Img08f7;
        public GImage Img1y4j;
        public const string URL = "ui://use7blkkqgn26n";

        public static BtnClose1 CreateInstance()
        {
            return (BtnClose1)UIPackage.CreateObject("BaseRes", "BtnClose1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img08f7 = (GImage)GetChild("Img08f7");
            Img1y4j = (GImage)GetChild("Img1y4j");
        }
    }
}