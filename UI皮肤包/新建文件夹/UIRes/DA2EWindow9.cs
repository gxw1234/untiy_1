/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow9 : GSlider
    {
        public GImage DA2ELoader5;
        public GImage bar;
        public grip2 grip;
        public const string URL = "ui://jk0io98jkn5zxg";

        public static DA2EWindow9 CreateInstance()
        {
            return (DA2EWindow9)UIPackage.CreateObject("UIRes", "DA2EWindow9");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2ELoader5 = (GImage)GetChild("DA2ELoader5");
            bar = (GImage)GetChild("bar");
            grip = (grip2)GetChild("grip");
        }
    }
}