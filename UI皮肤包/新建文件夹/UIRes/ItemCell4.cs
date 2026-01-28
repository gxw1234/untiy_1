/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ItemCell4 : GComponent
    {
        public GLoader Item;
        public GRichTextField Info;
        public const string URL = "ui://jk0io98jkn5zrs";

        public static ItemCell4 CreateInstance()
        {
            return (ItemCell4)UIPackage.CreateObject("UIRes", "ItemCell4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Item = (GLoader)GetChild("Item");
            Info = (GRichTextField)GetChild("Info");
        }
    }
}