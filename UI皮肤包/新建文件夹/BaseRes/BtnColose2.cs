/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class BtnColose2 : GButton
    {
        public Controller button;
        public GImage Img0bw5;
        public GImage Img1lk3;
        public const string URL = "ui://use7blkkqgn26s";

        public static BtnColose2 CreateInstance()
        {
            return (BtnColose2)UIPackage.CreateObject("BaseRes", "BtnColose2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img0bw5 = (GImage)GetChild("Img0bw5");
            Img1lk3 = (GImage)GetChild("Img1lk3");
        }
    }
}