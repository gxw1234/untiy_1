/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DA2ESimpleButton5 : GButton
    {
        public Controller button;
        public GImage Img10re5;
        public GImage Img11do2;
        public GTextField ChatEdit131;
        public const string URL = "ui://use7blkkqgn278";

        public static DA2ESimpleButton5 CreateInstance()
        {
            return (DA2ESimpleButton5)UIPackage.CreateObject("BaseRes", "DA2ESimpleButton5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10re5 = (GImage)GetChild("Img10re5");
            Img11do2 = (GImage)GetChild("Img11do2");
            ChatEdit131 = (GTextField)GetChild("ChatEdit131");
        }
    }
}