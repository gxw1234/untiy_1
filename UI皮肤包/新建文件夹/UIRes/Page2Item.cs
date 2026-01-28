/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page2Item : GButton
    {
        public Controller button;
        public GImage Img273280;
        public GImage Img303u4n;
        public GTextField ChatEdit14;
        public GTextField ChatEdit15;
        public GTextField ChatEdit38;
        public GTextField ChatEdit37;
        public GTextField ChatEdit29;
        public GImage caption;
        public const string URL = "ui://jk0io98jkn5zum";

        public static Page2Item CreateInstance()
        {
            return (Page2Item)UIPackage.CreateObject("UIRes", "Page2Item");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img273280 = (GImage)GetChild("Img273280");
            Img303u4n = (GImage)GetChild("Img303u4n");
            ChatEdit14 = (GTextField)GetChild("ChatEdit14");
            ChatEdit15 = (GTextField)GetChild("ChatEdit15");
            ChatEdit38 = (GTextField)GetChild("ChatEdit38");
            ChatEdit37 = (GTextField)GetChild("ChatEdit37");
            ChatEdit29 = (GTextField)GetChild("ChatEdit29");
            caption = (GImage)GetChild("caption");
        }
    }
}