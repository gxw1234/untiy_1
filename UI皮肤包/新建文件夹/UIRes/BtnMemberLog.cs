/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnMemberLog : GButton
    {
        public Controller button;
        public GImage Img191b5i;
        public GImage Img192581;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z186";

        public static BtnMemberLog CreateInstance()
        {
            return (BtnMemberLog)UIPackage.CreateObject("UIRes", "BtnMemberLog");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img191b5i = (GImage)GetChild("Img191b5i");
            Img192581 = (GImage)GetChild("Img192581");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}