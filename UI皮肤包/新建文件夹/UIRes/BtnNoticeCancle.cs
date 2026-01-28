/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnNoticeCancle : GButton
    {
        public Controller button;
        public GImage Img191nqc;
        public GImage Img192lii;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z176";

        public static BtnNoticeCancle CreateInstance()
        {
            return (BtnNoticeCancle)UIPackage.CreateObject("UIRes", "BtnNoticeCancle");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img191nqc = (GImage)GetChild("Img191nqc");
            Img192lii = (GImage)GetChild("Img192lii");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}