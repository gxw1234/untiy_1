/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ImgID : GComponent
    {
        public GGraph bg;
        public GTextField title;
        public GTextInput input;
        public const string URL = "ui://use7blkkqgn27f";

        public static ImgID CreateInstance()
        {
            return (ImgID)UIPackage.CreateObject("BaseRes", "ImgID");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GGraph)GetChild("bg");
            title = (GTextField)GetChild("title");
            input = (GTextInput)GetChild("input");
        }
    }
}