/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnCancelWar : GButton
    {
        public Controller button;
        public GImage Img10w3l;
        public GImage Img115d1;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkntcgvn2ws";

        public static BtnCancelWar CreateInstance()
        {
            return (BtnCancelWar)UIPackage.CreateObject("UIRes", "BtnCancelWar");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10w3l = (GImage)GetChild("Img10w3l");
            Img115d1 = (GImage)GetChild("Img115d1");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}