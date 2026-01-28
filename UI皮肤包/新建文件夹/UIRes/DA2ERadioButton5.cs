/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ERadioButton5 : GButton
    {
        public Controller button;
        public GImage Img885pl7;
        public GImage Img884765;
        public GTextField Text;
        public const string URL = "ui://jk0io98jkn5zzt";

        public static DA2ERadioButton5 CreateInstance()
        {
            return (DA2ERadioButton5)UIPackage.CreateObject("UIRes", "DA2ERadioButton5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img885pl7 = (GImage)GetChild("Img885pl7");
            Img884765 = (GImage)GetChild("Img884765");
            Text = (GTextField)GetChild("Text");
        }
    }
}