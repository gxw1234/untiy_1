/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ImgNum : GComponent
    {
        public GLoader Item;
        public GGraph Stroke;
        public const string URL = "ui://use7blkkqgn28u";

        public static ImgNum CreateInstance()
        {
            return (ImgNum)UIPackage.CreateObject("BaseRes", "ImgNum");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Item = (GLoader)GetChild("Item");
            Stroke = (GGraph)GetChild("Stroke");
        }
    }
}