/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DA2ESimpleButton8 : GButton
    {
        public Controller button;
        public GImage Img102og;
        public GImage Img11gq8;
        public GTextField ChatEdit136;
        public const string URL = "ui://use7blkkqgn27b";

        public static DA2ESimpleButton8 CreateInstance()
        {
            return (DA2ESimpleButton8)UIPackage.CreateObject("BaseRes", "DA2ESimpleButton8");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img102og = (GImage)GetChild("Img102og");
            Img11gq8 = (GImage)GetChild("Img11gq8");
            ChatEdit136 = (GTextField)GetChild("ChatEdit136");
        }
    }
}