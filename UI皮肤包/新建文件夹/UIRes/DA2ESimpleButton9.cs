/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton9 : GButton
    {
        public Controller button;
        public GImage Img265011;
        public GImage Img2665gg;
        public GTextField ChatEdit41;
        public const string URL = "ui://jk0io98jkn5zu7";

        public static DA2ESimpleButton9 CreateInstance()
        {
            return (DA2ESimpleButton9)UIPackage.CreateObject("UIRes", "DA2ESimpleButton9");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265011 = (GImage)GetChild("Img265011");
            Img2665gg = (GImage)GetChild("Img2665gg");
            ChatEdit41 = (GTextField)GetChild("ChatEdit41");
        }
    }
}