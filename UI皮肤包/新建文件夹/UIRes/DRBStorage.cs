/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DRBStorage : GButton
    {
        public Controller button;
        public GImage Img7938dw;
        public GImage Img794x05;
        public const string URL = "ui://jk0io98jv9b159";

        public static DRBStorage CreateInstance()
        {
            return (DRBStorage)UIPackage.CreateObject("UIRes", "DRBStorage");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img7938dw = (GImage)GetChild("Img7938dw");
            Img794x05 = (GImage)GetChild("Img794x05");
        }
    }
}