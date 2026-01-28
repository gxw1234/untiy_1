/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ERadioButton3 : GButton
    {
        public Controller button;
        public GImage Img885u3i;
        public GImage Img884qhl;
        public GTextField Text;
        public const string URL = "ui://jk0io98jkn5zzj";

        public static DA2ERadioButton3 CreateInstance()
        {
            return (DA2ERadioButton3)UIPackage.CreateObject("UIRes", "DA2ERadioButton3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img885u3i = (GImage)GetChild("Img885u3i");
            Img884qhl = (GImage)GetChild("Img884qhl");
            Text = (GTextField)GetChild("Text");
        }
    }
}