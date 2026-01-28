/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton8 : GButton
    {
        public Controller button;
        public GImage Img06yn;
        public GImage Img1k77;
        public const string URL = "ui://jk0io98jkn5zxv";

        public static DA2ESimpleButton8 CreateInstance()
        {
            return (DA2ESimpleButton8)UIPackage.CreateObject("UIRes", "DA2ESimpleButton8");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img06yn = (GImage)GetChild("Img06yn");
            Img1k77 = (GImage)GetChild("Img1k77");
        }
    }
}