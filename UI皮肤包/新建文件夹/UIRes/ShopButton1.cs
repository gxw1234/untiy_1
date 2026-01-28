/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ShopButton1 : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public GTextField title;
        public GTextField title_select;
        public const string URL = "ui://jk0io98jtybd7";

        public static ShopButton1 CreateInstance()
        {
            return (ShopButton1)UIPackage.CreateObject("UIRes", "ShopButton1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
            title = (GTextField)GetChild("title");
            title_select = (GTextField)GetChild("title_select");
        }
    }
}