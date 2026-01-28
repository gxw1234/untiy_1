/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ERadioButton1 : GButton
    {
        public Controller button;
        public GImage Img8855b5;
        public GImage Img884285;
        public GTextField Text;
        public const string URL = "ui://jk0io98jkn5zzh";

        public static DA2ERadioButton1 CreateInstance()
        {
            return (DA2ERadioButton1)UIPackage.CreateObject("UIRes", "DA2ERadioButton1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img8855b5 = (GImage)GetChild("Img8855b5");
            Img884285 = (GImage)GetChild("Img884285");
            Text = (GTextField)GetChild("Text");
        }
    }
}