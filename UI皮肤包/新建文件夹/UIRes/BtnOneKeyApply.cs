/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnOneKeyApply : GButton
    {
        public Controller button;
        public GImage Img191iyh;
        public GImage Img192275;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z17x";

        public static BtnOneKeyApply CreateInstance()
        {
            return (BtnOneKeyApply)UIPackage.CreateObject("UIRes", "BtnOneKeyApply");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img191iyh = (GImage)GetChild("Img191iyh");
            Img192275 = (GImage)GetChild("Img192275");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}