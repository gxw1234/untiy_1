/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComInfo : GComponent
    {
        public GImage bg;
        public GRichTextField title;
        public GImage blood;
        public const string URL = "ui://jk0io98js336gvn2w7";

        public static ComInfo CreateInstance()
        {
            return (ComInfo)UIPackage.CreateObject("UIRes", "ComInfo");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            title = (GRichTextField)GetChild("title");
            blood = (GImage)GetChild("blood");
        }
    }
}