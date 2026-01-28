/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ItemCell15 : GComponent
    {
        public GLoader Item;
        public GRichTextField Info;
        public const string URL = "ui://jk0io98jkn5zs5";

        public static ItemCell15 CreateInstance()
        {
            return (ItemCell15)UIPackage.CreateObject("UIRes", "ItemCell15");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Item = (GLoader)GetChild("Item");
            Info = (GRichTextField)GetChild("Info");
        }
    }
}