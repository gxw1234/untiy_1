/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComItem : GComponent
    {
        public GImage n0;
        public GLoader Icon;
        public GRichTextField name;
        public GRichTextField number;
        public const string URL = "ui://jk0io98js3369";

        public static ComItem CreateInstance()
        {
            return (ComItem)UIPackage.CreateObject("UIRes", "ComItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            Icon = (GLoader)GetChild("Icon");
            name = (GRichTextField)GetChild("name");
            number = (GRichTextField)GetChild("number");
        }
    }
}