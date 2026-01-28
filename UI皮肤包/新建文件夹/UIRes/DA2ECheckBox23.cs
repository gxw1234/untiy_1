/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox23 : GButton
    {
        public Controller button;
        public GImage Img415y34;
        public GImage Img4163lh;
        public const string URL = "ui://jk0io98jkn5zx4";

        public static DA2ECheckBox23 CreateInstance()
        {
            return (DA2ECheckBox23)UIPackage.CreateObject("UIRes", "DA2ECheckBox23");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415y34 = (GImage)GetChild("Img415y34");
            Img4163lh = (GImage)GetChild("Img4163lh");
        }
    }
}