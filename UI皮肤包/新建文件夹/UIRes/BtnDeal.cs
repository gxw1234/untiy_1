/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnDeal : GButton
    {
        public Controller button;
        public GImage Img10lww;
        public GImage Img11m1e;
        public GTextField ChatEdit1;
        public const string URL = "ui://jk0io98jkn5z18p";

        public static BtnDeal CreateInstance()
        {
            return (BtnDeal)UIPackage.CreateObject("UIRes", "BtnDeal");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10lww = (GImage)GetChild("Img10lww");
            Img11m1e = (GImage)GetChild("Img11m1e");
            ChatEdit1 = (GTextField)GetChild("ChatEdit1");
        }
    }
}