/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class UpgradeCell2 : GComponent
    {
        public GLoader Eff21;
        public GLoader Eff11;
        public GLoader item;
        public GTextField title;
        public GLoader Eff22;
        public GLoader Eff12;
        public GLoader Eff13;
        public GLoader Eff23;
        public GLoader bagsLod;
        public const string URL = "ui://jk0io98jhdg7vn2si";

        public static UpgradeCell2 CreateInstance()
        {
            return (UpgradeCell2)UIPackage.CreateObject("UIRes", "UpgradeCell2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Eff21 = (GLoader)GetChild("Eff21");
            Eff11 = (GLoader)GetChild("Eff11");
            item = (GLoader)GetChild("item");
            title = (GTextField)GetChild("title");
            Eff22 = (GLoader)GetChild("Eff22");
            Eff12 = (GLoader)GetChild("Eff12");
            Eff13 = (GLoader)GetChild("Eff13");
            Eff23 = (GLoader)GetChild("Eff23");
            bagsLod = (GLoader)GetChild("bagsLod");
        }
    }
}