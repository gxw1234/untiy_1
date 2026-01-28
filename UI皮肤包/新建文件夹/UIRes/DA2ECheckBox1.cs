/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox1 : GButton
    {
        public Controller button;
        public GImage Img415di6;
        public GImage Img416186;
        public const string URL = "ui://jk0io98jkn5zw5";

        public static DA2ECheckBox1 CreateInstance()
        {
            return (DA2ECheckBox1)UIPackage.CreateObject("UIRes", "DA2ECheckBox1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415di6 = (GImage)GetChild("Img415di6");
            Img416186 = (GImage)GetChild("Img416186");
        }
    }
}