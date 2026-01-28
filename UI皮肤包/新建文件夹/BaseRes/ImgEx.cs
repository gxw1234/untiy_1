/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ImgEx : GComponent
    {
        public GLoader load;
        public GRichTextField title0;
        public GRichTextField title1;
        public GRichTextField title2;
        public GRichTextField title3;
        public GGraph Stroke;
        public const string URL = "ui://use7blkkqgn28s";

        public static ImgEx CreateInstance()
        {
            return (ImgEx)UIPackage.CreateObject("BaseRes", "ImgEx");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            load = (GLoader)GetChild("load");
            title0 = (GRichTextField)GetChild("title0");
            title1 = (GRichTextField)GetChild("title1");
            title2 = (GRichTextField)GetChild("title2");
            title3 = (GRichTextField)GetChild("title3");
            Stroke = (GGraph)GetChild("Stroke");
        }
    }
}