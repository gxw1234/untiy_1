/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BgRadioBtn2 : GButton
    {
        public Controller button;
        public GImage Img8011b5;
        public GImage Img802847;
        public const string URL = "ui://jk0io98jv9b15b";

        public static BgRadioBtn2 CreateInstance()
        {
            return (BgRadioBtn2)UIPackage.CreateObject("UIRes", "BgRadioBtn2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img8011b5 = (GImage)GetChild("Img8011b5");
            Img802847 = (GImage)GetChild("Img802847");
        }
    }
}