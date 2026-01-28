/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class FashionDreCloseBtn : GButton
    {
        public Controller button;
        public GImage Img0k50;
        public GImage Img1680;
        public const string URL = "ui://jk0io98jkn5z19f";

        public static FashionDreCloseBtn CreateInstance()
        {
            return (FashionDreCloseBtn)UIPackage.CreateObject("UIRes", "FashionDreCloseBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img0k50 = (GImage)GetChild("Img0k50");
            Img1680 = (GImage)GetChild("Img1680");
        }
    }
}