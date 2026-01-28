/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton2 : GButton
    {
        public Controller button;
        public GImage Img239608;
        public GImage Img240k53;
        public GTextField ChatEdit2;
        public const string URL = "ui://jk0io98jruoyn2qx";

        public static DA2ESimpleButton2 CreateInstance()
        {
            return (DA2ESimpleButton2)UIPackage.CreateObject("UIRes", "DA2ESimpleButton2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img239608 = (GImage)GetChild("Img239608");
            Img240k53 = (GImage)GetChild("Img240k53");
            ChatEdit2 = (GTextField)GetChild("ChatEdit2");
        }
    }
}