/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox15 : GButton
    {
        public Controller button;
        public GImage Img415dt6;
        public GImage Img416825;
        public const string URL = "ui://jk0io98jkn5zwp";

        public static DA2ECheckBox15 CreateInstance()
        {
            return (DA2ECheckBox15)UIPackage.CreateObject("UIRes", "DA2ECheckBox15");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415dt6 = (GImage)GetChild("Img415dt6");
            Img416825 = (GImage)GetChild("Img416825");
        }
    }
}