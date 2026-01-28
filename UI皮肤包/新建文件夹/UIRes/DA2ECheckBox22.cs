/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox22 : GButton
    {
        public Controller button;
        public GImage Img4154s0;
        public GImage Img416ooh;
        public const string URL = "ui://jk0io98jkn5zx3";

        public static DA2ECheckBox22 CreateInstance()
        {
            return (DA2ECheckBox22)UIPackage.CreateObject("UIRes", "DA2ECheckBox22");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img4154s0 = (GImage)GetChild("Img4154s0");
            Img416ooh = (GImage)GetChild("Img416ooh");
        }
    }
}