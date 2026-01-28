/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class CancelBtn : GButton
    {
        public Controller button;
        public GImage Img108h0;
        public GImage Img11116;
        public GTextField ChatEdit170;
        public const string URL = "ui://use7blkkqgn27t";

        public static CancelBtn CreateInstance()
        {
            return (CancelBtn)UIPackage.CreateObject("BaseRes", "CancelBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img108h0 = (GImage)GetChild("Img108h0");
            Img11116 = (GImage)GetChild("Img11116");
            ChatEdit170 = (GTextField)GetChild("ChatEdit170");
        }
    }
}