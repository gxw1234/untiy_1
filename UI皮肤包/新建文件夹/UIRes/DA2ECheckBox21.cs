/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox21 : GButton
    {
        public Controller button;
        public GImage Img415s57;
        public GImage Img416q68;
        public const string URL = "ui://jk0io98jkn5zx2";

        public static DA2ECheckBox21 CreateInstance()
        {
            return (DA2ECheckBox21)UIPackage.CreateObject("UIRes", "DA2ECheckBox21");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415s57 = (GImage)GetChild("Img415s57");
            Img416q68 = (GImage)GetChild("Img416q68");
        }
    }
}