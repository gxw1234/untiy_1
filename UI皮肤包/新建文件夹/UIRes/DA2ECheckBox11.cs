/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox11 : GButton
    {
        public Controller button;
        public GImage Img415sx4;
        public GImage Img416wb6;
        public const string URL = "ui://jk0io98jkn5zwk";

        public static DA2ECheckBox11 CreateInstance()
        {
            return (DA2ECheckBox11)UIPackage.CreateObject("UIRes", "DA2ECheckBox11");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415sx4 = (GImage)GetChild("Img415sx4");
            Img416wb6 = (GImage)GetChild("Img416wb6");
        }
    }
}