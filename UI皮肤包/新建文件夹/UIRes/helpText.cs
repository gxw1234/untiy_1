/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class helpText : GComponent
    {
        public GRichTextField n0;
        public GRichTextField title;
        public const string URL = "ui://jk0io98js3365";

        public static helpText CreateInstance()
        {
            return (helpText)UIPackage.CreateObject("UIRes", "helpText");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GRichTextField)GetChild("n0");
            title = (GRichTextField)GetChild("title");
        }
    }
}