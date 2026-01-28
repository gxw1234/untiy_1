/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ERadioButton10 : GButton
    {
        public Controller button;
        public GImage Img88525k;
        public GImage Img88413t;
        public GTextField Text;
        public const string URL = "ui://jk0io98jkn5zzy";

        public static DA2ERadioButton10 CreateInstance()
        {
            return (DA2ERadioButton10)UIPackage.CreateObject("UIRes", "DA2ERadioButton10");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img88525k = (GImage)GetChild("Img88525k");
            Img88413t = (GImage)GetChild("Img88413t");
            Text = (GTextField)GetChild("Text");
        }
    }
}