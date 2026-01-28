/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ERadioButton9 : GButton
    {
        public Controller button;
        public GImage Img8851e5;
        public GImage Img884688;
        public GTextField Text;
        public const string URL = "ui://jk0io98jkn5zzx";

        public static DA2ERadioButton9 CreateInstance()
        {
            return (DA2ERadioButton9)UIPackage.CreateObject("UIRes", "DA2ERadioButton9");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img8851e5 = (GImage)GetChild("Img8851e5");
            Img884688 = (GImage)GetChild("Img884688");
            Text = (GTextField)GetChild("Text");
        }
    }
}