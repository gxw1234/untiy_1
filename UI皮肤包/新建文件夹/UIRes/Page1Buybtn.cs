/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page1Buybtn : GButton
    {
        public Controller button;
        public GImage Img10ehn;
        public GImage Img11ct5;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z11w";

        public static Page1Buybtn CreateInstance()
        {
            return (Page1Buybtn)UIPackage.CreateObject("UIRes", "Page1Buybtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10ehn = (GImage)GetChild("Img10ehn");
            Img11ct5 = (GImage)GetChild("Img11ct5");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}