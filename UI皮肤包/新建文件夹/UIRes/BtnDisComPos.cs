/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnDisComPos : GButton
    {
        public Controller button;
        public GImage Img191251;
        public GImage Img1922x2;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z17r";

        public static BtnDisComPos CreateInstance()
        {
            return (BtnDisComPos)UIPackage.CreateObject("UIRes", "BtnDisComPos");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img191251 = (GImage)GetChild("Img191251");
            Img1922x2 = (GImage)GetChild("Img1922x2");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}