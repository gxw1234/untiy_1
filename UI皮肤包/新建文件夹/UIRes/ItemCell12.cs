/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ItemCell12 : GComponent
    {
        public GLoader Item;
        public GRichTextField Info;
        public const string URL = "ui://jk0io98jkn5zs2";

        public static ItemCell12 CreateInstance()
        {
            return (ItemCell12)UIPackage.CreateObject("UIRes", "ItemCell12");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Item = (GLoader)GetChild("Item");
            Info = (GRichTextField)GetChild("Info");
        }
    }
}