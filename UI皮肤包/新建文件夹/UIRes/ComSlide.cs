/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComSlide : GSlider
    {
        public GImage DA2ELoader7;
        public GImage bar;
        public grip4 grip;
        public const string URL = "ui://jk0io98js46a1h";

        public static ComSlide CreateInstance()
        {
            return (ComSlide)UIPackage.CreateObject("UIRes", "ComSlide");
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