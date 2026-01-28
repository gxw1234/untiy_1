/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DChatWindowItem : GComponent
    {
        public GGraph ChatWindowBG;
        public GRichTextField ChatWindowText;
        public DChatWinowitGrap DChatWinowitGrap;
        public const string URL = "ui://jk0io98jv9b1g2";

        public static DChatWindowItem CreateInstance()
        {
            return (DChatWindowItem)UIPackage.CreateObject("UIRes", "DChatWindowItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            ChatWindowBG = (GGraph)GetChild("ChatWindowBG");
            ChatWindowText = (GRichTextField)GetChild("ChatWindowText");
            DChatWinowitGrap = (DChatWinowitGrap)GetChild("DChatWinowitGrap");
        }
    }
}