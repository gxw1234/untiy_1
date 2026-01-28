/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox28 : GButton
    {
        public Controller button;
        public GImage Img4155mh;
        public GImage Img416b37;
        public const string URL = "ui://jk0io98jkn5zx9";

        public static DA2ECheckBox28 CreateInstance()
        {
            return (DA2ECheckBox28)UIPackage.CreateObject("UIRes", "DA2ECheckBox28");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img4155mh = (GImage)GetChild("Img4155mh");
            Img416b37 = (GImage)GetChild("Img416b37");
        }
    }
}