/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox6 : GButton
    {
        public Controller button;
        public GImage Img4150k4;
        public GImage Img4160ud;
        public const string URL = "ui://jk0io98jkn5zwf";

        public static DA2ECheckBox6 CreateInstance()
        {
            return (DA2ECheckBox6)UIPackage.CreateObject("UIRes", "DA2ECheckBox6");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img4150k4 = (GImage)GetChild("Img4150k4");
            Img4160ud = (GImage)GetChild("Img4160ud");
        }
    }
}