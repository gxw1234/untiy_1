/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BagCustomBtn4 : GButton
    {
        public Controller button;
        public GImage Img10es4;
        public GImage Img1146b;
        public GTextField ChatEdit13;
        public const string URL = "ui://jk0io98jv9b15i";

        public static BagCustomBtn4 CreateInstance()
        {
            return (BagCustomBtn4)UIPackage.CreateObject("UIRes", "BagCustomBtn4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10es4 = (GImage)GetChild("Img10es4");
            Img1146b = (GImage)GetChild("Img1146b");
            ChatEdit13 = (GTextField)GetChild("ChatEdit13");
        }
    }
}