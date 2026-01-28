/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox9 : GButton
    {
        public Controller button;
        public GImage Img415kx7;
        public GImage Img41613i;
        public const string URL = "ui://jk0io98jkn5zwi";

        public static DA2ECheckBox9 CreateInstance()
        {
            return (DA2ECheckBox9)UIPackage.CreateObject("UIRes", "DA2ECheckBox9");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415kx7 = (GImage)GetChild("Img415kx7");
            Img41613i = (GImage)GetChild("Img41613i");
        }
    }
}