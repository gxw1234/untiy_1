/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox13 : GButton
    {
        public Controller button;
        public GImage Img415bc8;
        public GImage Img4162t3;
        public const string URL = "ui://jk0io98jkn5zwm";

        public static DA2ECheckBox13 CreateInstance()
        {
            return (DA2ECheckBox13)UIPackage.CreateObject("UIRes", "DA2ECheckBox13");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415bc8 = (GImage)GetChild("Img415bc8");
            Img4162t3 = (GImage)GetChild("Img4162t3");
        }
    }
}