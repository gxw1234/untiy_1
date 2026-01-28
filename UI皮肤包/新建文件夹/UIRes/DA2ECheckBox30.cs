/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox30 : GButton
    {
        public Controller button;
        public GImage Img4154e4;
        public GImage Img416e70;
        public const string URL = "ui://jk0io98jkn5zxx";

        public static DA2ECheckBox30 CreateInstance()
        {
            return (DA2ECheckBox30)UIPackage.CreateObject("UIRes", "DA2ECheckBox30");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img4154e4 = (GImage)GetChild("Img4154e4");
            Img416e70 = (GImage)GetChild("Img416e70");
        }
    }
}