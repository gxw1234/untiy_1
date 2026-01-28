/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox27 : GButton
    {
        public Controller button;
        public GImage Img415m37;
        public GImage Img4167w8;
        public const string URL = "ui://jk0io98jkn5zx8";

        public static DA2ECheckBox27 CreateInstance()
        {
            return (DA2ECheckBox27)UIPackage.CreateObject("UIRes", "DA2ECheckBox27");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415m37 = (GImage)GetChild("Img415m37");
            Img4167w8 = (GImage)GetChild("Img4167w8");
        }
    }
}