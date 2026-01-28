/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox24 : GButton
    {
        public Controller button;
        public GImage Img415ibg;
        public GImage Img416385;
        public const string URL = "ui://jk0io98jkn5zx5";

        public static DA2ECheckBox24 CreateInstance()
        {
            return (DA2ECheckBox24)UIPackage.CreateObject("UIRes", "DA2ECheckBox24");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415ibg = (GImage)GetChild("Img415ibg");
            Img416385 = (GImage)GetChild("Img416385");
        }
    }
}