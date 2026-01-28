/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ERadioButton6 : GButton
    {
        public Controller button;
        public GImage Img8850cj;
        public GImage Img884562;
        public GTextField Text;
        public const string URL = "ui://jk0io98jkn5zzu";

        public static DA2ERadioButton6 CreateInstance()
        {
            return (DA2ERadioButton6)UIPackage.CreateObject("UIRes", "DA2ERadioButton6");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img8850cj = (GImage)GetChild("Img8850cj");
            Img884562 = (GImage)GetChild("Img884562");
            Text = (GTextField)GetChild("Text");
        }
    }
}