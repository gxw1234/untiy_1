/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton12 : GButton
    {
        public Controller button;
        public GImage Img265265;
        public GImage Img266yu8;
        public GTextField ChatEdit58;
        public const string URL = "ui://jk0io98jkn5ztf";

        public static DA2ESimpleButton12 CreateInstance()
        {
            return (DA2ESimpleButton12)UIPackage.CreateObject("UIRes", "DA2ESimpleButton12");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265265 = (GImage)GetChild("Img265265");
            Img266yu8 = (GImage)GetChild("Img266yu8");
            ChatEdit58 = (GTextField)GetChild("ChatEdit58");
        }
    }
}