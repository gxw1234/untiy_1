/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BoxGiftBtn : GButton
    {
        public Controller button;
        public GImage n4;
        public GImage n5;
        public const string URL = "ui://jk0io98jkvjygvn2uj";

        public static BoxGiftBtn CreateInstance()
        {
            return (BoxGiftBtn)UIPackage.CreateObject("UIRes", "BoxGiftBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n4 = (GImage)GetChild("n4");
            n5 = (GImage)GetChild("n5");
        }
    }
}