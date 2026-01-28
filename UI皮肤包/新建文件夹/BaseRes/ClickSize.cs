/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ClickSize : GComponent
    {
        public GGraph bg;
        public GGraph Stroke;
        public const string URL = "ui://use7blkkqgn28f";

        public static ClickSize CreateInstance()
        {
            return (ClickSize)UIPackage.CreateObject("BaseRes", "ClickSize");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GGraph)GetChild("bg");
            Stroke = (GGraph)GetChild("Stroke");
        }
    }
}