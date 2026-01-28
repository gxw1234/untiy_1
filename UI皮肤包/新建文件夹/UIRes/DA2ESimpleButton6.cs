/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton6 : GButton
    {
        public Controller button;
        public GImage Img2653l8;
        public GImage Img266uvd;
        public GTextField ChatEdit57;
        public const string URL = "ui://jk0io98jkn5ztm";

        public static DA2ESimpleButton6 CreateInstance()
        {
            return (DA2ESimpleButton6)UIPackage.CreateObject("UIRes", "DA2ESimpleButton6");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2653l8 = (GImage)GetChild("Img2653l8");
            Img266uvd = (GImage)GetChild("Img266uvd");
            ChatEdit57 = (GTextField)GetChild("ChatEdit57");
        }
    }
}