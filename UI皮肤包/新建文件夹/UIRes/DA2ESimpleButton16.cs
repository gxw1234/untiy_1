/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton16 : GButton
    {
        public Controller button;
        public GImage Img28661q;
        public GImage Img287k2u;
        public GTextField ChatEdit56;
        public const string URL = "ui://jk0io98jkn5zug";

        public static DA2ESimpleButton16 CreateInstance()
        {
            return (DA2ESimpleButton16)UIPackage.CreateObject("UIRes", "DA2ESimpleButton16");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img28661q = (GImage)GetChild("Img28661q");
            Img287k2u = (GImage)GetChild("Img287k2u");
            ChatEdit56 = (GTextField)GetChild("ChatEdit56");
        }
    }
}