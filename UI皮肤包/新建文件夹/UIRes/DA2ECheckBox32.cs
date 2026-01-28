/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox32 : GButton
    {
        public Controller button;
        public GImage Img415u4h;
        public GImage Img416ukg;
        public const string URL = "ui://jk0io98jkn5zy0";

        public static DA2ECheckBox32 CreateInstance()
        {
            return (DA2ECheckBox32)UIPackage.CreateObject("UIRes", "DA2ECheckBox32");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415u4h = (GImage)GetChild("Img415u4h");
            Img416ukg = (GImage)GetChild("Img416ukg");
        }
    }
}