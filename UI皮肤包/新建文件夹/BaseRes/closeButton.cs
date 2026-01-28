/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class closeButton : GButton
    {
        public Controller button;
        public GImage Img0i63;
        public GImage Img1861;
        public const string URL = "ui://use7blkkqgn26l";

        public static closeButton CreateInstance()
        {
            return (closeButton)UIPackage.CreateObject("BaseRes", "closeButton");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img0i63 = (GImage)GetChild("Img0i63");
            Img1861 = (GImage)GetChild("Img1861");
        }
    }
}