/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottomEMailBtn : GButton
    {
        public Controller button;
        public GImage Img830s78;
        public GImage Img830x1e;
        public const string URL = "ui://jk0io98jv9b11m";

        public static BottomEMailBtn CreateInstance()
        {
            return (BottomEMailBtn)UIPackage.CreateObject("UIRes", "BottomEMailBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img830s78 = (GImage)GetChild("Img830s78");
            Img830x1e = (GImage)GetChild("Img830x1e");
        }
    }
}