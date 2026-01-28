/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnPosCancle : GButton
    {
        public Controller button;
        public GImage Img1912k2;
        public GImage Img19238y;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z170";

        public static BtnPosCancle CreateInstance()
        {
            return (BtnPosCancle)UIPackage.CreateObject("UIRes", "BtnPosCancle");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1912k2 = (GImage)GetChild("Img1912k2");
            Img19238y = (GImage)GetChild("Img19238y");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}