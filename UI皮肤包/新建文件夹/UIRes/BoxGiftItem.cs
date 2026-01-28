/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BoxGiftItem : GComponent
    {
        public GImage bg;
        public GLoader img;
        public GTextField num;
        public GTextField name;
        public const string URL = "ui://jk0io98jfxnkvn2sf";

        public static BoxGiftItem CreateInstance()
        {
            return (BoxGiftItem)UIPackage.CreateObject("UIRes", "BoxGiftItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            img = (GLoader)GetChild("img");
            num = (GTextField)GetChild("num");
            name = (GTextField)GetChild("name");
        }
    }
}