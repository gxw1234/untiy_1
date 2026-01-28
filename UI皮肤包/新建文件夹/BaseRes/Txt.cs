/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class Txt : GComponent
    {
        public GRichTextField Txt;
        public GGraph Stroke;
        public const string URL = "ui://use7blkkqgn29a";

        public static Txt CreateInstance()
        {
            return (Txt)UIPackage.CreateObject("BaseRes", "Txt");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Txt = (GRichTextField)GetChild("Txt");
            Stroke = (GGraph)GetChild("Stroke");
        }
    }
}