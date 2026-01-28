/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ItemCell11 : GComponent
    {
        public GLoader Item;
        public GRichTextField Info;
        public const string URL = "ui://jk0io98jkn5zs1";

        public static ItemCell11 CreateInstance()
        {
            return (ItemCell11)UIPackage.CreateObject("UIRes", "ItemCell11");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Item = (GLoader)GetChild("Item");
            Info = (GRichTextField)GetChild("Info");
        }
    }
}