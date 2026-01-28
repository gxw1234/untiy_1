/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ShopNameButton : GButton
    {
        public Controller button;
        public GTextField title_1;
        public GTextField title;
        public const string URL = "ui://jk0io98jm9ogd";

        public static ShopNameButton CreateInstance()
        {
            return (ShopNameButton)UIPackage.CreateObject("UIRes", "ShopNameButton");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            title_1 = (GTextField)GetChild("title_1");
            title = (GTextField)GetChild("title");
        }
    }
}