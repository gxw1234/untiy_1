/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton21 : GButton
    {
        public Controller button;
        public GImage Img265mf7;
        public GImage Img26626l;
        public GTextField ChatEdit50;
        public const string URL = "ui://jk0io98jkn5zu0";

        public static DA2ESimpleButton21 CreateInstance()
        {
            return (DA2ESimpleButton21)UIPackage.CreateObject("UIRes", "DA2ESimpleButton21");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265mf7 = (GImage)GetChild("Img265mf7");
            Img26626l = (GImage)GetChild("Img26626l");
            ChatEdit50 = (GTextField)GetChild("ChatEdit50");
        }
    }
}