/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class BtnOk2 : GButton
    {
        public Controller button;
        public GImage Img10bpv;
        public GImage Img11g7h;
        public GTextField ChatEdit1;
        public const string URL = "ui://use7blkkqgn26r";

        public static BtnOk2 CreateInstance()
        {
            return (BtnOk2)UIPackage.CreateObject("BaseRes", "BtnOk2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10bpv = (GImage)GetChild("Img10bpv");
            Img11g7h = (GImage)GetChild("Img11g7h");
            ChatEdit1 = (GTextField)GetChild("ChatEdit1");
        }
    }
}