/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnRepealApply : GButton
    {
        public Controller button;
        public GImage Img107vs;
        public GImage Img1140w;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z17h";

        public static BtnRepealApply CreateInstance()
        {
            return (BtnRepealApply)UIPackage.CreateObject("UIRes", "BtnRepealApply");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img107vs = (GImage)GetChild("Img107vs");
            Img1140w = (GImage)GetChild("Img1140w");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}