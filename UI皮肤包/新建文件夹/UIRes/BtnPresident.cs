/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnPresident : GButton
    {
        public Controller button;
        public GImage Img176rvi;
        public GImage Img1774nc;
        public const string URL = "ui://jk0io98jkn5z172";

        public static BtnPresident CreateInstance()
        {
            return (BtnPresident)UIPackage.CreateObject("UIRes", "BtnPresident");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img176rvi = (GImage)GetChild("Img176rvi");
            Img1774nc = (GImage)GetChild("Img1774nc");
        }
    }
}