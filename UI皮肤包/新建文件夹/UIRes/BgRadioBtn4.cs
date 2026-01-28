/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BgRadioBtn4 : GButton
    {
        public Controller button;
        public GImage Img8050i1;
        public GImage Img806c5c;
        public const string URL = "ui://jk0io98jv9b15d";

        public static BgRadioBtn4 CreateInstance()
        {
            return (BgRadioBtn4)UIPackage.CreateObject("UIRes", "BgRadioBtn4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img8050i1 = (GImage)GetChild("Img8050i1");
            Img806c5c = (GImage)GetChild("Img806c5c");
        }
    }
}