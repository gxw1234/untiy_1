/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox29 : GButton
    {
        public Controller button;
        public GImage Img415s4x;
        public GImage Img416qx7;
        public const string URL = "ui://jk0io98jkn5zxa";

        public static DA2ECheckBox29 CreateInstance()
        {
            return (DA2ECheckBox29)UIPackage.CreateObject("UIRes", "DA2ECheckBox29");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415s4x = (GImage)GetChild("Img415s4x");
            Img416qx7 = (GImage)GetChild("Img416qx7");
        }
    }
}