/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class PlayImgEx : GComponent
    {
        public GLoader load;
        public GRichTextField title;
        public GGraph Stroke;
        public const string URL = "ui://use7blkkqgn296";

        public static PlayImgEx CreateInstance()
        {
            return (PlayImgEx)UIPackage.CreateObject("BaseRes", "PlayImgEx");
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