/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton20 : GButton
    {
        public Controller button;
        public GImage Img265ipi;
        public GImage Img266u01;
        public GTextField ChatEdit49;
        public const string URL = "ui://jk0io98jkn5ztz";

        public static DA2ESimpleButton20 CreateInstance()
        {
            return (DA2ESimpleButton20)UIPackage.CreateObject("UIRes", "DA2ESimpleButton20");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265ipi = (GImage)GetChild("Img265ipi");
            Img266u01 = (GImage)GetChild("Img266u01");
            ChatEdit49 = (GTextField)GetChild("ChatEdit49");
        }
    }
}