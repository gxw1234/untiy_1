/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnBoxGiftPlatform : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public GTextField btnTitle;
        public const string URL = "ui://jk0io98jfxnkvn2s9";

        public static BtnBoxGiftPlatform CreateInstance()
        {
            return (BtnBoxGiftPlatform)UIPackage.CreateObject("UIRes", "BtnBoxGiftPlatform");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
            btnTitle = (GTextField)GetChild("btnTitle");
        }
    }
}