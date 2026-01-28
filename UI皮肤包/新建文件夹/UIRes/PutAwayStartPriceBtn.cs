/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class PutAwayStartPriceBtn : GButton
    {
        public Controller button;
        public GImage Img625ra8;
        public GImage Img62550f;
        public const string URL = "ui://jk0io98jkn5z12g";

        public static PutAwayStartPriceBtn CreateInstance()
        {
            return (PutAwayStartPriceBtn)UIPackage.CreateObject("UIRes", "PutAwayStartPriceBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img625ra8 = (GImage)GetChild("Img625ra8");
            Img62550f = (GImage)GetChild("Img62550f");
        }
    }
}