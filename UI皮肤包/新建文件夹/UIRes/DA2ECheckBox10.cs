/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox10 : GButton
    {
        public Controller button;
        public GImage Img4158cg;
        public GImage Img416gp2;
        public const string URL = "ui://jk0io98jkn5zwj";

        public static DA2ECheckBox10 CreateInstance()
        {
            return (DA2ECheckBox10)UIPackage.CreateObject("UIRes", "DA2ECheckBox10");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img4158cg = (GImage)GetChild("Img4158cg");
            Img416gp2 = (GImage)GetChild("Img416gp2");
        }
    }
}