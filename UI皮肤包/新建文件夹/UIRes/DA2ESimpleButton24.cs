/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton24 : GButton
    {
        public Controller button;
        public GImage Img28608r;
        public GImage Img287xo1;
        public GTextField ChatEdit53;
        public const string URL = "ui://jk0io98jkn5zue";

        public static DA2ESimpleButton24 CreateInstance()
        {
            return (DA2ESimpleButton24)UIPackage.CreateObject("UIRes", "DA2ESimpleButton24");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img28608r = (GImage)GetChild("Img28608r");
            Img287xo1 = (GImage)GetChild("Img287xo1");
            ChatEdit53 = (GTextField)GetChild("ChatEdit53");
        }
    }
}