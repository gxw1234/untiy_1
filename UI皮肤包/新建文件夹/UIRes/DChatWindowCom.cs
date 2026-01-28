/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DChatWindowCom : GComponent
    {
        public GGraph Graph;
        public GRichTextField Text;
        public const string URL = "ui://jk0io98jv9b1g1";

        public static DChatWindowCom CreateInstance()
        {
            return (DChatWindowCom)UIPackage.CreateObject("UIRes", "DChatWindowCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Graph = (GGraph)GetChild("Graph");
            Text = (GRichTextField)GetChild("Text");
        }
    }
}