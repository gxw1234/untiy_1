/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox34 : GButton
    {
        public Controller button;
        public GImage Img415q16;
        public GImage Img41687u;
        public const string URL = "ui://jk0io98jkn5zxj";

        public static DA2ECheckBox34 CreateInstance()
        {
            return (DA2ECheckBox34)UIPackage.CreateObject("UIRes", "DA2ECheckBox34");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415q16 = (GImage)GetChild("Img415q16");
            Img41687u = (GImage)GetChild("Img41687u");
        }
    }
}