/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DScrollBar_arrow2 : GButton
    {
        public Controller button;
        public GImage Img248bb;
        public GImage Img26dtb;
        public const string URL = "ui://jk0io98jldxan2q0";

        public static DScrollBar_arrow2 CreateInstance()
        {
            return (DScrollBar_arrow2)UIPackage.CreateObject("UIRes", "DScrollBar_arrow2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img248bb = (GImage)GetChild("Img248bb");
            Img26dtb = (GImage)GetChild("Img26dtb");
        }
    }
}