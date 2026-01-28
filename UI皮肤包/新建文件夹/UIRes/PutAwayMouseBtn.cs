/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class PutAwayMouseBtn : GButton
    {
        public Controller button;
        public GImage Img6251wp;
        public GImage Img625535;
        public const string URL = "ui://jk0io98jkn5z12h";

        public static PutAwayMouseBtn CreateInstance()
        {
            return (PutAwayMouseBtn)UIPackage.CreateObject("UIRes", "PutAwayMouseBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img6251wp = (GImage)GetChild("Img6251wp");
            Img625535 = (GImage)GetChild("Img625535");
        }
    }
}