/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ERadioButton7 : GButton
    {
        public Controller button;
        public GImage Img8856p7;
        public GImage Img884mbv;
        public GTextField Text;
        public const string URL = "ui://jk0io98jkn5zzv";

        public static DA2ERadioButton7 CreateInstance()
        {
            return (DA2ERadioButton7)UIPackage.CreateObject("UIRes", "DA2ERadioButton7");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img8856p7 = (GImage)GetChild("Img8856p7");
            Img884mbv = (GImage)GetChild("Img884mbv");
            Text = (GTextField)GetChild("Text");
        }
    }
}