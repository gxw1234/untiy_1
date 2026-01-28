/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnNoticeSave : GButton
    {
        public Controller button;
        public GImage Img1914p2;
        public GImage Img192qt6;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z175";

        public static BtnNoticeSave CreateInstance()
        {
            return (BtnNoticeSave)UIPackage.CreateObject("UIRes", "BtnNoticeSave");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1914p2 = (GImage)GetChild("Img1914p2");
            Img192qt6 = (GImage)GetChild("Img192qt6");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}