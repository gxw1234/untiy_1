/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class Progress : GComponent
    {
        public GRichTextField TxtNameLv;
        public GLoader progressBg;
        public GLoader progressFg;
        public const string URL = "ui://us2ut3jfr7r83j";

        public static Progress CreateInstance()
        {
            return (Progress)UIPackage.CreateObject("UILoadingRes", "Progress");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            TxtNameLv = (GRichTextField)GetChild("TxtNameLv");
            progressBg = (GLoader)GetChild("progressBg");
            progressFg = (GLoader)GetChild("progressFg");
        }
    }
}