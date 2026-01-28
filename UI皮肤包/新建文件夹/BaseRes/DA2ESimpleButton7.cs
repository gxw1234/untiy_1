/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DA2ESimpleButton7 : GButton
    {
        public Controller button;
        public GImage Img10028;
        public GImage Img11fxp;
        public GTextField ChatEdit135;
        public const string URL = "ui://use7blkkqgn27a";

        public static DA2ESimpleButton7 CreateInstance()
        {
            return (DA2ESimpleButton7)UIPackage.CreateObject("BaseRes", "DA2ESimpleButton7");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10028 = (GImage)GetChild("Img10028");
            Img11fxp = (GImage)GetChild("Img11fxp");
            ChatEdit135 = (GTextField)GetChild("ChatEdit135");
        }
    }
}