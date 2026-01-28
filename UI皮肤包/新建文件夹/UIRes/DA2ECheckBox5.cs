/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox5 : GButton
    {
        public Controller button;
        public GImage Img415ut5;
        public GImage Img416a3x;
        public const string URL = "ui://jk0io98jkn5zwe";

        public static DA2ECheckBox5 CreateInstance()
        {
            return (DA2ECheckBox5)UIPackage.CreateObject("UIRes", "DA2ECheckBox5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415ut5 = (GImage)GetChild("Img415ut5");
            Img416a3x = (GImage)GetChild("Img416a3x");
        }
    }
}