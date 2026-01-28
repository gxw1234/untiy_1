/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ProgressBar : GProgressBar
    {
        public GLoader bg;
        public GLoader bar;
        public GTextField title;
        public GGraph Stroke;
        public const string URL = "ui://use7blkkqgn298";

        public static ProgressBar CreateInstance()
        {
            return (ProgressBar)UIPackage.CreateObject("BaseRes", "ProgressBar");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GLoader)GetChild("bg");
            bar = (GLoader)GetChild("bar");
            title = (GTextField)GetChild("title");
            Stroke = (GGraph)GetChild("Stroke");
        }
    }
}