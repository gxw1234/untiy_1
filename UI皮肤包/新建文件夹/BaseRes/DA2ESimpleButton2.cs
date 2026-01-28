/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DA2ESimpleButton2 : GButton
    {
        public Controller button;
        public GImage Img104w3;
        public GImage Img11wx6;
        public GTextField ChatEdit15;
        public const string URL = "ui://use7blkkqgn274";

        public static DA2ESimpleButton2 CreateInstance()
        {
            return (DA2ESimpleButton2)UIPackage.CreateObject("BaseRes", "DA2ESimpleButton2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img104w3 = (GImage)GetChild("Img104w3");
            Img11wx6 = (GImage)GetChild("Img11wx6");
            ChatEdit15 = (GTextField)GetChild("ChatEdit15");
        }
    }
}