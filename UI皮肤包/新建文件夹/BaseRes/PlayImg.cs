/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class PlayImg : GComponent
    {
        public GLoader load;
        public GRichTextField title;
        public GGraph Stroke;
        public const string URL = "ui://use7blkkqgn294";

        public static PlayImg CreateInstance()
        {
            return (PlayImg)UIPackage.CreateObject("BaseRes", "PlayImg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            load = (GLoader)GetChild("load");
            title = (GRichTextField)GetChild("title");
            Stroke = (GGraph)GetChild("Stroke");
        }
    }
}