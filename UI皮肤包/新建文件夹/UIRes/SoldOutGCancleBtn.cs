/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class SoldOutGCancleBtn : GButton
    {
        public Controller button;
        public GImage Img265x0d;
        public GImage Img2663c7;
        public GTextField ChatEdit50;
        public const string URL = "ui://jk0io98jkn5z12m";

        public static SoldOutGCancleBtn CreateInstance()
        {
            return (SoldOutGCancleBtn)UIPackage.CreateObject("UIRes", "SoldOutGCancleBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265x0d = (GImage)GetChild("Img265x0d");
            Img2663c7 = (GImage)GetChild("Img2663c7");
            ChatEdit50 = (GTextField)GetChild("ChatEdit50");
        }
    }
}