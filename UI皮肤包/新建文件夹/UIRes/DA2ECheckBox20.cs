/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox20 : GButton
    {
        public Controller button;
        public GImage Img415ar0;
        public GImage Img416ina;
        public const string URL = "ui://jk0io98jkn5zx1";

        public static DA2ECheckBox20 CreateInstance()
        {
            return (DA2ECheckBox20)UIPackage.CreateObject("UIRes", "DA2ECheckBox20");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415ar0 = (GImage)GetChild("Img415ar0");
            Img416ina = (GImage)GetChild("Img416ina");
        }
    }
}