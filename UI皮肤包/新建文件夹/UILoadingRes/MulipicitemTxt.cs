/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class MulipicitemTxt : GComponent
    {
        public GRichTextField Txt;
        public const string URL = "ui://us2ut3jfs5ye62";

        public static MulipicitemTxt CreateInstance()
        {
            return (MulipicitemTxt)UIPackage.CreateObject("UILoadingRes", "MulipicitemTxt");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Txt = (GRichTextField)GetChild("Txt");
        }
    }
}