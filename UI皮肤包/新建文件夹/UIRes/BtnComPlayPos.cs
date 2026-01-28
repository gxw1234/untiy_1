/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnComPlayPos : GButton
    {
        public Controller button;
        public GImage Img191vgd;
        public GImage Img192co3;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z17n";

        public static BtnComPlayPos CreateInstance()
        {
            return (BtnComPlayPos)UIPackage.CreateObject("UIRes", "BtnComPlayPos");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img191vgd = (GImage)GetChild("Img191vgd");
            Img192co3 = (GImage)GetChild("Img192co3");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}