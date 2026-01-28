/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton25 : GButton
    {
        public Controller button;
        public GImage Img286yd4;
        public GImage Img2876ay;
        public GTextField ChatEdit54;
        public const string URL = "ui://jk0io98jkn5zuf";

        public static DA2ESimpleButton25 CreateInstance()
        {
            return (DA2ESimpleButton25)UIPackage.CreateObject("UIRes", "DA2ESimpleButton25");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img286yd4 = (GImage)GetChild("Img286yd4");
            Img2876ay = (GImage)GetChild("Img2876ay");
            ChatEdit54 = (GTextField)GetChild("ChatEdit54");
        }
    }
}