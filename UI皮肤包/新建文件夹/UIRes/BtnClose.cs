/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnClose : GButton
    {
        public Controller button;
        public GImage Img1834dl;
        public GImage Img1842et;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5zs6";

        public static BtnClose CreateInstance()
        {
            return (BtnClose)UIPackage.CreateObject("UIRes", "BtnClose");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1834dl = (GImage)GetChild("Img1834dl");
            Img1842et = (GImage)GetChild("Img1842et");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}