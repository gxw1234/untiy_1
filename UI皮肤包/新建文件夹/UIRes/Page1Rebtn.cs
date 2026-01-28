/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page1Rebtn : GButton
    {
        public Controller button;
        public GImage Img10r7k;
        public GImage Img114hj;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z11v";

        public static Page1Rebtn CreateInstance()
        {
            return (Page1Rebtn)UIPackage.CreateObject("UIRes", "Page1Rebtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10r7k = (GImage)GetChild("Img10r7k");
            Img114hj = (GImage)GetChild("Img114hj");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}