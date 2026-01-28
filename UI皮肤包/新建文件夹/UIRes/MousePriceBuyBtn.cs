/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class MousePriceBuyBtn : GButton
    {
        public Controller button;
        public GImage Img265ecf;
        public GImage Img2662f3;
        public GTextField ChatEdit58;
        public const string URL = "ui://jk0io98jkn5z12x";

        public static MousePriceBuyBtn CreateInstance()
        {
            return (MousePriceBuyBtn)UIPackage.CreateObject("UIRes", "MousePriceBuyBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265ecf = (GImage)GetChild("Img265ecf");
            Img2662f3 = (GImage)GetChild("Img2662f3");
            ChatEdit58 = (GTextField)GetChild("ChatEdit58");
        }
    }
}