/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox19 : GButton
    {
        public Controller button;
        public GImage Img415w57;
        public GImage Img416yeo;
        public const string URL = "ui://jk0io98jkn5zwy";

        public static DA2ECheckBox19 CreateInstance()
        {
            return (DA2ECheckBox19)UIPackage.CreateObject("UIRes", "DA2ECheckBox19");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415w57 = (GImage)GetChild("Img415w57");
            Img416yeo = (GImage)GetChild("Img416yeo");
        }
    }
}