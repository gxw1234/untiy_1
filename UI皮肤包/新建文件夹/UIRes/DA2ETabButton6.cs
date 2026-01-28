/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ETabButton6 : GButton
    {
        public Controller button;
        public GImage Img346360;
        public GImage Img345y1l;
        public GTextField ChatEdit67;
        public const string URL = "ui://jk0io98jws588";

        public static DA2ETabButton6 CreateInstance()
        {
            return (DA2ETabButton6)UIPackage.CreateObject("UIRes", "DA2ETabButton6");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img346360 = (GImage)GetChild("Img346360");
            Img345y1l = (GImage)GetChild("Img345y1l");
            ChatEdit67 = (GTextField)GetChild("ChatEdit67");
        }
    }
}