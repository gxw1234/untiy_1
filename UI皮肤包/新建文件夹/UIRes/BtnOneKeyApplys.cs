/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnOneKeyApplys : GButton
    {
        public Controller button;
        public GImage Img101gd;
        public GImage Img113iq;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z17g";

        public static BtnOneKeyApplys CreateInstance()
        {
            return (BtnOneKeyApplys)UIPackage.CreateObject("UIRes", "BtnOneKeyApplys");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img101gd = (GImage)GetChild("Img101gd");
            Img113iq = (GImage)GetChild("Img113iq");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}