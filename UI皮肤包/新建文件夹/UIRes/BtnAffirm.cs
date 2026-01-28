/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnAffirm : GButton
    {
        public Controller button;
        public GImage Img3667cd;
        public GImage Img36710d;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jj3e21gc";

        public static BtnAffirm CreateInstance()
        {
            return (BtnAffirm)UIPackage.CreateObject("UIRes", "BtnAffirm");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img3667cd = (GImage)GetChild("Img3667cd");
            Img36710d = (GImage)GetChild("Img36710d");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}