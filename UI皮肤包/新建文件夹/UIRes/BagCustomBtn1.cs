/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BagCustomBtn1 : GButton
    {
        public Controller button;
        public GImage Img10h1w;
        public GImage Img1103a;
        public GTextField ChatEdit1;
        public const string URL = "ui://jk0io98jv9b15f";

        public static BagCustomBtn1 CreateInstance()
        {
            return (BagCustomBtn1)UIPackage.CreateObject("UIRes", "BagCustomBtn1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10h1w = (GImage)GetChild("Img10h1w");
            Img1103a = (GImage)GetChild("Img1103a");
            ChatEdit1 = (GTextField)GetChild("ChatEdit1");
        }
    }
}