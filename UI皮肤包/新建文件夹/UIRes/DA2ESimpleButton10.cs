/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton10 : GButton
    {
        public Controller button;
        public GImage Img2650v3;
        public GImage Img266g1v;
        public GTextField ChatEdit42;
        public const string URL = "ui://jk0io98jkn5zu8";

        public static DA2ESimpleButton10 CreateInstance()
        {
            return (DA2ESimpleButton10)UIPackage.CreateObject("UIRes", "DA2ESimpleButton10");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2650v3 = (GImage)GetChild("Img2650v3");
            Img266g1v = (GImage)GetChild("Img266g1v");
            ChatEdit42 = (GTextField)GetChild("ChatEdit42");
        }
    }
}