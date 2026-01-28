/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DScrollBar_grip : GButton
    {
        public Controller button;
        public GImage Img278s8;
        public GImage Img2904t;
        public const string URL = "ui://jk0io98jldxan2q1";

        public static DScrollBar_grip CreateInstance()
        {
            return (DScrollBar_grip)UIPackage.CreateObject("UIRes", "DScrollBar_grip");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img278s8 = (GImage)GetChild("Img278s8");
            Img2904t = (GImage)GetChild("Img2904t");
        }
    }
}