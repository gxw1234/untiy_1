/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow10 : GSlider
    {
        public GImage DA2ELoader7;
        public GImage bar;
        public grip4 grip;
        public const string URL = "ui://jk0io98jkn5zxi";

        public static DA2EWindow10 CreateInstance()
        {
            return (DA2EWindow10)UIPackage.CreateObject("UIRes", "DA2EWindow10");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2ELoader7 = (GImage)GetChild("DA2ELoader7");
            bar = (GImage)GetChild("bar");
            grip = (grip4)GetChild("grip");
        }
    }
}