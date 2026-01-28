/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox35 : GButton
    {
        public Controller button;
        public GImage Img415n01;
        public GImage Img416t10;
        public const string URL = "ui://jk0io98jkn5zxl";

        public static DA2ECheckBox35 CreateInstance()
        {
            return (DA2ECheckBox35)UIPackage.CreateObject("UIRes", "DA2ECheckBox35");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415n01 = (GImage)GetChild("Img415n01");
            Img416t10 = (GImage)GetChild("Img416t10");
        }
    }
}