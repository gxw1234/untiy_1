/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class FashionStyBtn : GButton
    {
        public Controller button;
        public GImage Img6015dh;
        public GImage Img60233r;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z19i";

        public static FashionStyBtn CreateInstance()
        {
            return (FashionStyBtn)UIPackage.CreateObject("UIRes", "FashionStyBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img6015dh = (GImage)GetChild("Img6015dh");
            Img60233r = (GImage)GetChild("Img60233r");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}