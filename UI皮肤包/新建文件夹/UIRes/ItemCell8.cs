/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ItemCell8 : GComponent
    {
        public GLoader Item;
        public GRichTextField Info;
        public const string URL = "ui://jk0io98jkn5zrw";

        public static ItemCell8 CreateInstance()
        {
            return (ItemCell8)UIPackage.CreateObject("UIRes", "ItemCell8");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Item = (GLoader)GetChild("Item");
            Info = (GRichTextField)GetChild("Info");
        }
    }
}