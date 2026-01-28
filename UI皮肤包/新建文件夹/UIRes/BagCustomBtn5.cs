/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BagCustomBtn5 : GButton
    {
        public Controller button;
        public GImage Img10fbk;
        public GImage Img11y73;
        public GTextField ChatEdit14;
        public const string URL = "ui://jk0io98jv9b15j";

        public static BagCustomBtn5 CreateInstance()
        {
            return (BagCustomBtn5)UIPackage.CreateObject("UIRes", "BagCustomBtn5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10fbk = (GImage)GetChild("Img10fbk");
            Img11y73 = (GImage)GetChild("Img11y73");
            ChatEdit14 = (GTextField)GetChild("ChatEdit14");
        }
    }
}