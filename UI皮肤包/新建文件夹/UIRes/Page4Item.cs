/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page4Item : GButton
    {
        public Controller button;
        public GImage Img27334a;
        public GImage Img3038in;
        public DA2ESimpleButton24 DA2ESimpleButton24;
        public DA2ESimpleButton25 DA2ESimpleButton25;
        public GTextField ChatEdit33;
        public GTextField ChatEdit34;
        public GTextField ChatEdit35;
        public const string URL = "ui://jk0io98jkn5zuo";

        public static Page4Item CreateInstance()
        {
            return (Page4Item)UIPackage.CreateObject("UIRes", "Page4Item");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img27334a = (GImage)GetChild("Img27334a");
            Img3038in = (GImage)GetChild("Img3038in");
            DA2ESimpleButton24 = (DA2ESimpleButton24)GetChild("DA2ESimpleButton24");
            DA2ESimpleButton25 = (DA2ESimpleButton25)GetChild("DA2ESimpleButton25");
            ChatEdit33 = (GTextField)GetChild("ChatEdit33");
            ChatEdit34 = (GTextField)GetChild("ChatEdit34");
            ChatEdit35 = (GTextField)GetChild("ChatEdit35");
        }
    }
}