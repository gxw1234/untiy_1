/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnSave : GButton
    {
        public Controller button;
        public GImage Img1913y6;
        public GImage Img192pht;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z16w";

        public static BtnSave CreateInstance()
        {
            return (BtnSave)UIPackage.CreateObject("UIRes", "BtnSave");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1913y6 = (GImage)GetChild("Img1913y6");
            Img192pht = (GImage)GetChild("Img192pht");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}