/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BgRadioBtn3 : GButton
    {
        public Controller button;
        public GImage Img803807;
        public GImage Img8040t4;
        public const string URL = "ui://jk0io98jv9b15c";

        public static BgRadioBtn3 CreateInstance()
        {
            return (BgRadioBtn3)UIPackage.CreateObject("UIRes", "BgRadioBtn3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img803807 = (GImage)GetChild("Img803807");
            Img8040t4 = (GImage)GetChild("Img8040t4");
        }
    }
}