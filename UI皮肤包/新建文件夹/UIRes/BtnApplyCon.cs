/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnApplyCon : GButton
    {
        public Controller button;
        public GImage Img191uwb;
        public GImage Img192311;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z183";

        public static BtnApplyCon CreateInstance()
        {
            return (BtnApplyCon)UIPackage.CreateObject("UIRes", "BtnApplyCon");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img191uwb = (GImage)GetChild("Img191uwb");
            Img192311 = (GImage)GetChild("Img192311");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}