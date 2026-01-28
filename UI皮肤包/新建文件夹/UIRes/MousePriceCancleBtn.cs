/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class MousePriceCancleBtn : GButton
    {
        public Controller button;
        public GImage Img265qg2;
        public GImage Img2664wv;
        public GTextField ChatEdit57;
        public const string URL = "ui://jk0io98jkn5z12w";

        public static MousePriceCancleBtn CreateInstance()
        {
            return (MousePriceCancleBtn)UIPackage.CreateObject("UIRes", "MousePriceCancleBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265qg2 = (GImage)GetChild("Img265qg2");
            Img2664wv = (GImage)GetChild("Img2664wv");
            ChatEdit57 = (GTextField)GetChild("ChatEdit57");
        }
    }
}