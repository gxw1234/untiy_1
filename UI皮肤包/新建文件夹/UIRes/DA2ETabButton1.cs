/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ETabButton1 : GButton
    {
        public Controller button;
        public GImage Img4308t6;
        public GImage Img429708;
        public const string URL = "ui://jk0io98jkn5zxp";

        public static DA2ETabButton1 CreateInstance()
        {
            return (DA2ETabButton1)UIPackage.CreateObject("UIRes", "DA2ETabButton1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img4308t6 = (GImage)GetChild("Img4308t6");
            Img429708 = (GImage)GetChild("Img429708");
        }
    }
}