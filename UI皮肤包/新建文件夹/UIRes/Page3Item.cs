/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page3Item : GButton
    {
        public Controller button;
        public GImage Img273b04;
        public GImage Img3034ib;
        public DA2ESimpleButton16 DA2ESimpleButton16;
        public GTextField ChatEdit30;
        public GTextField ChatEdit31;
        public GTextField ChatEdit32;
        public GTextField ChatEdit36;
        public const string URL = "ui://jk0io98jkn5zun";

        public static Page3Item CreateInstance()
        {
            return (Page3Item)UIPackage.CreateObject("UIRes", "Page3Item");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img273b04 = (GImage)GetChild("Img273b04");
            Img3034ib = (GImage)GetChild("Img3034ib");
            DA2ESimpleButton16 = (DA2ESimpleButton16)GetChild("DA2ESimpleButton16");
            ChatEdit30 = (GTextField)GetChild("ChatEdit30");
            ChatEdit31 = (GTextField)GetChild("ChatEdit31");
            ChatEdit32 = (GTextField)GetChild("ChatEdit32");
            ChatEdit36 = (GTextField)GetChild("ChatEdit36");
        }
    }
}