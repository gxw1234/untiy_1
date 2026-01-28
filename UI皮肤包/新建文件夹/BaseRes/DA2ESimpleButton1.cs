/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DA2ESimpleButton1 : GButton
    {
        public Controller button;
        public GImage Img1050u;
        public GImage Img114uc;
        public GTextField ChatEdit13;
        public const string URL = "ui://use7blkkqgn273";

        public static DA2ESimpleButton1 CreateInstance()
        {
            return (DA2ESimpleButton1)UIPackage.CreateObject("BaseRes", "DA2ESimpleButton1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1050u = (GImage)GetChild("Img1050u");
            Img114uc = (GImage)GetChild("Img114uc");
            ChatEdit13 = (GTextField)GetChild("ChatEdit13");
        }
    }
}