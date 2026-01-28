/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnConfirm : GButton
    {
        public Controller button;
        public GImage Img191rfy;
        public GImage Img192668;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z171";

        public static BtnConfirm CreateInstance()
        {
            return (BtnConfirm)UIPackage.CreateObject("UIRes", "BtnConfirm");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img191rfy = (GImage)GetChild("Img191rfy");
            Img192668 = (GImage)GetChild("Img192668");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}