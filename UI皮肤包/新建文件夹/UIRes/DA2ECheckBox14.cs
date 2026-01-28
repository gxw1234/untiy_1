/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox14 : GButton
    {
        public Controller button;
        public GImage Img41563u;
        public GImage Img4163fn;
        public const string URL = "ui://jk0io98jkn5zwn";

        public static DA2ECheckBox14 CreateInstance()
        {
            return (DA2ECheckBox14)UIPackage.CreateObject("UIRes", "DA2ECheckBox14");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img41563u = (GImage)GetChild("Img41563u");
            Img4163fn = (GImage)GetChild("Img4163fn");
        }
    }
}