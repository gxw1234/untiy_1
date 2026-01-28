/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BgRadioBtn5 : GButton
    {
        public Controller button;
        public GImage Img80736l;
        public GImage Img808gqa;
        public const string URL = "ui://jk0io98jv9b15e";

        public static BgRadioBtn5 CreateInstance()
        {
            return (BgRadioBtn5)UIPackage.CreateObject("UIRes", "BgRadioBtn5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img80736l = (GImage)GetChild("Img80736l");
            Img808gqa = (GImage)GetChild("Img808gqa");
        }
    }
}