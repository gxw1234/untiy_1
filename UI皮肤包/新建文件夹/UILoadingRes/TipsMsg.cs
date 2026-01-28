/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class TipsMsg : GComponent
    {
        public GRichTextField Content;
        public const string URL = "ui://us2ut3jfr7r83m";

        public static TipsMsg CreateInstance()
        {
            return (TipsMsg)UIPackage.CreateObject("UILoadingRes", "TipsMsg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Content = (GRichTextField)GetChild("Content");
        }
    }
}