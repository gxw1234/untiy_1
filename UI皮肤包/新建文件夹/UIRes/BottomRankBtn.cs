/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottomRankBtn : GButton
    {
        public Controller button;
        public GImage Img882n84;
        public GImage Img883ss7;
        public const string URL = "ui://jk0io98jv9b11t";

        public static BottomRankBtn CreateInstance()
        {
            return (BottomRankBtn)UIPackage.CreateObject("UIRes", "BottomRankBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img882n84 = (GImage)GetChild("Img882n84");
            Img883ss7 = (GImage)GetChild("Img883ss7");
        }
    }
}