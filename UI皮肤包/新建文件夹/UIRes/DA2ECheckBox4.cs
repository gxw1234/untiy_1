/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox4 : GButton
    {
        public Controller button;
        public GImage Img415t0c;
        public GImage Img4166g0;
        public const string URL = "ui://jk0io98jkn5zwd";

        public static DA2ECheckBox4 CreateInstance()
        {
            return (DA2ECheckBox4)UIPackage.CreateObject("UIRes", "DA2ECheckBox4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415t0c = (GImage)GetChild("Img415t0c");
            Img4166g0 = (GImage)GetChild("Img4166g0");
        }
    }
}