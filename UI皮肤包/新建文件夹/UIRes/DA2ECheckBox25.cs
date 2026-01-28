/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox25 : GButton
    {
        public Controller button;
        public GImage Img41554r;
        public GImage Img416bpn;
        public const string URL = "ui://jk0io98jkn5zx6";

        public static DA2ECheckBox25 CreateInstance()
        {
            return (DA2ECheckBox25)UIPackage.CreateObject("UIRes", "DA2ECheckBox25");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img41554r = (GImage)GetChild("Img41554r");
            Img416bpn = (GImage)GetChild("Img416bpn");
        }
    }
}