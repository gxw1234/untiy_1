/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnDeclareWar : GButton
    {
        public Controller button;
        public GImage Img10qrk;
        public GImage Img11546;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z17u";

        public static BtnDeclareWar CreateInstance()
        {
            return (BtnDeclareWar)UIPackage.CreateObject("UIRes", "BtnDeclareWar");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10qrk = (GImage)GetChild("Img10qrk");
            Img11546 = (GImage)GetChild("Img11546");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}