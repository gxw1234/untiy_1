/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow8 : GSlider
    {
        public GImage DA2ELoader3;
        public GImage bar;
        public grip1 grip;
        public const string URL = "ui://jk0io98jkn5zxe";

        public static DA2EWindow8 CreateInstance()
        {
            return (DA2EWindow8)UIPackage.CreateObject("UIRes", "DA2EWindow8");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2ELoader3 = (GImage)GetChild("DA2ELoader3");
            bar = (GImage)GetChild("bar");
            grip = (grip1)GetChild("grip");
        }
    }
}