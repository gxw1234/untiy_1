/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DMissionTitle : GComponent
    {
        public GRichTextField title;
        public const string URL = "ui://jk0io98jvn2xg";

        public static DMissionTitle CreateInstance()
        {
            return (DMissionTitle)UIPackage.CreateObject("UIRes", "DMissionTitle");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            title = (GRichTextField)GetChild("title");
        }
    }
}