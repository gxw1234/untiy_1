/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class Item : GComponent
    {
        public GLoader Eff21;
        public GLoader Eff11;
        public GLoader Icon;
        public GTextField itemCount;
        public GLoader Eff22;
        public GLoader Eff12;
        public GLoader Eff23;
        public GLoader Eff13;
        public GLoader bagsLod1;
        public GLoader bagsLod2;
        public GLoader bagsLod3;
        public const string URL = "ui://us2ut3jfr7r83f";

        public static Item CreateInstance()
        {
            return (Item)UIPackage.CreateObject("UILoadingRes", "Item");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Eff21 = (GLoader)GetChild("Eff21");
            Eff11 = (GLoader)GetChild("Eff11");
            Icon = (GLoader)GetChild("Icon");
            itemCount = (GTextField)GetChild("itemCount");
            Eff22 = (GLoader)GetChild("Eff22");
            Eff12 = (GLoader)GetChild("Eff12");
            Eff23 = (GLoader)GetChild("Eff23");
            Eff13 = (GLoader)GetChild("Eff13");
            bagsLod1 = (GLoader)GetChild("bagsLod1");
            bagsLod2 = (GLoader)GetChild("bagsLod2");
            bagsLod3 = (GLoader)GetChild("bagsLod3");
        }
    }
}