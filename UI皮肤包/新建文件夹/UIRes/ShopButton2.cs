/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ShopButton2 : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public GTextField title;
        public GTextField title_select;
        public const string URL = "ui://jk0io98jtybda";

        public static ShopButton2 CreateInstance()
        {
            return (ShopButton2)UIPackage.CreateObject("UIRes", "ShopButton2");
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