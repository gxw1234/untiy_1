/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox33 : GButton
    {
        public Controller button;
        public GImage Img4152b6;
        public GImage Img4161j6;
        public const string URL = "ui://jk0io98jkn5zy1";

        public static DA2ECheckBox33 CreateInstance()
        {
            return (DA2ECheckBox33)UIPackage.CreateObject("UIRes", "DA2ECheckBox33");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img4152b6 = (GImage)GetChild("Img4152b6");
            Img4161j6 = (GImage)GetChild("Img4161j6");
        }
    }
}