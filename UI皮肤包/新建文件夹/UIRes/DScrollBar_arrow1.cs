/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DScrollBar_arrow1 : GButton
    {
        public Controller button;
        public GImage Img21h8v;
        public GImage Img23nmy;
        public const string URL = "ui://jk0io98jldxan2pz";

        public static DScrollBar_arrow1 CreateInstance()
        {
            return (DScrollBar_arrow1)UIPackage.CreateObject("UIRes", "DScrollBar_arrow1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img21h8v = (GImage)GetChild("Img21h8v");
            Img23nmy = (GImage)GetChild("Img23nmy");
        }
    }
}