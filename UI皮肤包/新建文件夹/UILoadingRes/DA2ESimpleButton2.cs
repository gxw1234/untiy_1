/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DA2ESimpleButton2 : GButton
    {
        public Controller button;
        public GImage Img392osd;
        public GImage Img3932hv;
        public const string URL = "ui://us2ut3jfr7r81n";

        public static DA2ESimpleButton2 CreateInstance()
        {
            return (DA2ESimpleButton2)UIPackage.CreateObject("UILoadingRes", "DA2ESimpleButton2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img392osd = (GImage)GetChild("Img392osd");
            Img3932hv = (GImage)GetChild("Img3932hv");
        }
    }
}