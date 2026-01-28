/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DA2ESimpleButton6 : GButton
    {
        public Controller button;
        public GImage Img106e6;
        public GImage Img1151s;
        public GTextField ChatEdit134;
        public const string URL = "ui://use7blkkqgn279";

        public static DA2ESimpleButton6 CreateInstance()
        {
            return (DA2ESimpleButton6)UIPackage.CreateObject("BaseRes", "DA2ESimpleButton6");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img106e6 = (GImage)GetChild("Img106e6");
            Img1151s = (GImage)GetChild("Img1151s");
            ChatEdit134 = (GTextField)GetChild("ChatEdit134");
        }
    }
}