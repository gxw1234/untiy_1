/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox12 : GButton
    {
        public Controller button;
        public GImage Img415x1u;
        public GImage Img4167h8;
        public const string URL = "ui://jk0io98jkn5zwl";

        public static DA2ECheckBox12 CreateInstance()
        {
            return (DA2ECheckBox12)UIPackage.CreateObject("UIRes", "DA2ECheckBox12");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415x1u = (GImage)GetChild("Img415x1u");
            Img4167h8 = (GImage)GetChild("Img4167h8");
        }
    }
}