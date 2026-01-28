/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class LoadBtn : GButton
    {
        public Controller button;
        public GImage Img10v1l;
        public GImage Img11mrk;
        public GTextField ChatEdit11;
        public const string URL = "ui://use7blkkqgn271";

        public static LoadBtn CreateInstance()
        {
            return (LoadBtn)UIPackage.CreateObject("BaseRes", "LoadBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10v1l = (GImage)GetChild("Img10v1l");
            Img11mrk = (GImage)GetChild("Img11mrk");
            ChatEdit11 = (GTextField)GetChild("ChatEdit11");
        }
    }
}