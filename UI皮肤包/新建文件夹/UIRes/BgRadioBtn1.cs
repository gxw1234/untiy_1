/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BgRadioBtn1 : GButton
    {
        public Controller button;
        public GImage Img799n24;
        public GImage Img800j81;
        public const string URL = "ui://jk0io98jv9b15a";

        public static BgRadioBtn1 CreateInstance()
        {
            return (BgRadioBtn1)UIPackage.CreateObject("UIRes", "BgRadioBtn1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img799n24 = (GImage)GetChild("Img799n24");
            Img800j81 = (GImage)GetChild("Img800j81");
        }
    }
}