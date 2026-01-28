/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnBuyClose : GButton
    {
        public Controller button;
        public GImage Img0kb7;
        public GImage Img15q1;
        public const string URL = "ui://jk0io98jj3e21g9";

        public static BtnBuyClose CreateInstance()
        {
            return (BtnBuyClose)UIPackage.CreateObject("UIRes", "BtnBuyClose");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img0kb7 = (GImage)GetChild("Img0kb7");
            Img15q1 = (GImage)GetChild("Img15q1");
        }
    }
}