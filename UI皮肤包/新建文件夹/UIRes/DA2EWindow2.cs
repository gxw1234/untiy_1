/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow2 : GSlider
    {
        public GImage n0;
        public GImage bar;
        public grip grip;
        public const string URL = "ui://jk0io98jkn5zw9";

        public static DA2EWindow2 CreateInstance()
        {
            return (DA2EWindow2)UIPackage.CreateObject("UIRes", "DA2EWindow2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            bar = (GImage)GetChild("bar");
            grip = (grip)GetChild("grip");
        }
    }
}