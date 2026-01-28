/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox31 : GButton
    {
        public Controller button;
        public GImage Img415hd4;
        public GImage Img416678;
        public const string URL = "ui://jk0io98jkn5zxy";

        public static DA2ECheckBox31 CreateInstance()
        {
            return (DA2ECheckBox31)UIPackage.CreateObject("UIRes", "DA2ECheckBox31");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415hd4 = (GImage)GetChild("Img415hd4");
            Img416678 = (GImage)GetChild("Img416678");
        }
    }
}