/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class TxtIrem : GComponent
    {
        public GRichTextField Content;
        public GLoader imgloader;
        public const string URL = "ui://us2ut3jfr7r83n";

        public static TxtIrem CreateInstance()
        {
            return (TxtIrem)UIPackage.CreateObject("UILoadingRes", "TxtIrem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Content = (GRichTextField)GetChild("Content");
            imgloader = (GLoader)GetChild("imgloader");
        }
    }
}