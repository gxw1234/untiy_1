/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DA2ESimpleButton4 : GButton
    {
        public Controller button;
        public GImage Img108ub;
        public GImage Img1107n;
        public GTextField ChatEdit31;
        public const string URL = "ui://use7blkkqgn277";

        public static DA2ESimpleButton4 CreateInstance()
        {
            return (DA2ESimpleButton4)UIPackage.CreateObject("BaseRes", "DA2ESimpleButton4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img108ub = (GImage)GetChild("Img108ub");
            Img1107n = (GImage)GetChild("Img1107n");
            ChatEdit31 = (GTextField)GetChild("ChatEdit31");
        }
    }
}