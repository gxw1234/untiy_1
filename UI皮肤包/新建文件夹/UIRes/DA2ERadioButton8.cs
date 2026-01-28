/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ERadioButton8 : GButton
    {
        public Controller button;
        public GImage Img885lb7;
        public GImage Img884gb0;
        public GTextField Text;
        public const string URL = "ui://jk0io98jkn5zzw";

        public static DA2ERadioButton8 CreateInstance()
        {
            return (DA2ERadioButton8)UIPackage.CreateObject("UIRes", "DA2ERadioButton8");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img885lb7 = (GImage)GetChild("Img885lb7");
            Img884gb0 = (GImage)GetChild("Img884gb0");
            Text = (GTextField)GetChild("Text");
        }
    }
}