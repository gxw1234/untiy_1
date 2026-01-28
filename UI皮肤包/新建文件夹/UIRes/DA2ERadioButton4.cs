/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ERadioButton4 : GButton
    {
        public Controller button;
        public GImage Img885h26;
        public GImage Img884xib;
        public GTextField Text;
        public const string URL = "ui://jk0io98jkn5zzk";

        public static DA2ERadioButton4 CreateInstance()
        {
            return (DA2ERadioButton4)UIPackage.CreateObject("UIRes", "DA2ERadioButton4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img885h26 = (GImage)GetChild("Img885h26");
            Img884xib = (GImage)GetChild("Img884xib");
            Text = (GTextField)GetChild("Text");
        }
    }
}