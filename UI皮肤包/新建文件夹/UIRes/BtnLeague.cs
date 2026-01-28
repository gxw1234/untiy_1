/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnLeague : GButton
    {
        public Controller button;
        public GImage Img10704;
        public GImage Img11s0d;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z17w";

        public static BtnLeague CreateInstance()
        {
            return (BtnLeague)UIPackage.CreateObject("UIRes", "BtnLeague");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10704 = (GImage)GetChild("Img10704");
            Img11s0d = (GImage)GetChild("Img11s0d");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}