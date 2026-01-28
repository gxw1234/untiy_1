/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ERadioButton2 : GButton
    {
        public Controller button;
        public GImage Img885v6m;
        public GImage Img884566;
        public GTextField Text;
        public const string URL = "ui://jk0io98jkn5zzi";

        public static DA2ERadioButton2 CreateInstance()
        {
            return (DA2ERadioButton2)UIPackage.CreateObject("UIRes", "DA2ERadioButton2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img885v6m = (GImage)GetChild("Img885v6m");
            Img884566 = (GImage)GetChild("Img884566");
            Text = (GTextField)GetChild("Text");
        }
    }
}