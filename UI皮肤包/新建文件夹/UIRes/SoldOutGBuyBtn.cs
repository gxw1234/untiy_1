/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class SoldOutGBuyBtn : GButton
    {
        public Controller button;
        public GImage Img2652eh;
        public GImage Img2664fm;
        public GTextField ChatEdit51;
        public const string URL = "ui://jk0io98jkn5z12n";

        public static SoldOutGBuyBtn CreateInstance()
        {
            return (SoldOutGBuyBtn)UIPackage.CreateObject("UIRes", "SoldOutGBuyBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2652eh = (GImage)GetChild("Img2652eh");
            Img2664fm = (GImage)GetChild("Img2664fm");
            ChatEdit51 = (GTextField)GetChild("ChatEdit51");
        }
    }
}