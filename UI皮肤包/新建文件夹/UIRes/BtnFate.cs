/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnFate : GButton
    {
        public Controller button;
        public GImage Img184g17;
        public GImage Img18335f;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jxa7ql";

        public static BtnFate CreateInstance()
        {
            return (BtnFate)UIPackage.CreateObject("UIRes", "BtnFate");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img184g17 = (GImage)GetChild("Img184g17");
            Img18335f = (GImage)GetChild("Img18335f");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}