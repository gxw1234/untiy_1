/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnConCancle : GButton
    {
        public Controller button;
        public GImage Img19158i;
        public GImage Img192473;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z16v";

        public static BtnConCancle CreateInstance()
        {
            return (BtnConCancle)UIPackage.CreateObject("UIRes", "BtnConCancle");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img19158i = (GImage)GetChild("Img19158i");
            Img192473 = (GImage)GetChild("Img192473");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}