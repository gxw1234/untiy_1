/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DA2ESimpleButton3 : GButton
    {
        public Controller button;
        public GImage Img3900f8;
        public GImage Img391vmu;
        public const string URL = "ui://us2ut3jfr7r81o";

        public static DA2ESimpleButton3 CreateInstance()
        {
            return (DA2ESimpleButton3)UIPackage.CreateObject("UILoadingRes", "DA2ESimpleButton3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img3900f8 = (GImage)GetChild("Img3900f8");
            Img391vmu = (GImage)GetChild("Img391vmu");
        }
    }
}