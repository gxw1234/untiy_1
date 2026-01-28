/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton5 : GButton
    {
        public Controller button;
        public GImage Img265h7y;
        public GImage Img26657a;
        public GTextField ChatEdit59;
        public const string URL = "ui://jk0io98jkn5ztd";

        public static DA2ESimpleButton5 CreateInstance()
        {
            return (DA2ESimpleButton5)UIPackage.CreateObject("UIRes", "DA2ESimpleButton5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265h7y = (GImage)GetChild("Img265h7y");
            Img26657a = (GImage)GetChild("Img26657a");
            ChatEdit59 = (GTextField)GetChild("ChatEdit59");
        }
    }
}