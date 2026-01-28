/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton3 : GButton
    {
        public Controller button;
        public GImage Img265312;
        public GImage Img266btx;
        public GTextField ChatEdit47;
        public const string URL = "ui://jk0io98jkn5zu3";

        public static DA2ESimpleButton3 CreateInstance()
        {
            return (DA2ESimpleButton3)UIPackage.CreateObject("UIRes", "DA2ESimpleButton3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265312 = (GImage)GetChild("Img265312");
            Img266btx = (GImage)GetChild("Img266btx");
            ChatEdit47 = (GTextField)GetChild("ChatEdit47");
        }
    }
}