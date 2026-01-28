/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox2 : GButton
    {
        public Controller button;
        public GImage Img415sh4;
        public GImage Img416o10;
        public const string URL = "ui://jk0io98jkn5zwb";

        public static DA2ECheckBox2 CreateInstance()
        {
            return (DA2ECheckBox2)UIPackage.CreateObject("UIRes", "DA2ECheckBox2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415sh4 = (GImage)GetChild("Img415sh4");
            Img416o10 = (GImage)GetChild("Img416o10");
        }
    }
}