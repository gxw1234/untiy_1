/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ETabButton2 : GButton
    {
        public Controller button;
        public GImage Img4348t4;
        public GImage Img433mi6;
        public const string URL = "ui://jk0io98jkn5zxq";

        public static DA2ETabButton2 CreateInstance()
        {
            return (DA2ETabButton2)UIPackage.CreateObject("UIRes", "DA2ETabButton2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img4348t4 = (GImage)GetChild("Img4348t4");
            Img433mi6 = (GImage)GetChild("Img433mi6");
        }
    }
}