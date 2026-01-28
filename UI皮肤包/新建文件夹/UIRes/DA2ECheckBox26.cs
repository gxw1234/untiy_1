/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox26 : GButton
    {
        public Controller button;
        public GImage Img415703;
        public GImage Img4168i6;
        public const string URL = "ui://jk0io98jkn5zx7";

        public static DA2ECheckBox26 CreateInstance()
        {
            return (DA2ECheckBox26)UIPackage.CreateObject("UIRes", "DA2ECheckBox26");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415703 = (GImage)GetChild("Img415703");
            Img4168i6 = (GImage)GetChild("Img4168i6");
        }
    }
}