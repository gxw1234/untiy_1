/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class EquipCell31 : GComponent
    {
        public GLoader Eff21;
        public GLoader Eff11;
        public GLoader item;
        public GTextField title;
        public GLoader Eff22;
        public GLoader Eff12;
        public GLoader Eff23;
        public GLoader Eff13;
        public GLoader bagsLod;
        public GTextField IconXY;
        public GTextField EffectXY;
        public GTextField StarLevel;
        public const string URL = "ui://jk0io98jj3e21jj";

        public static EquipCell31 CreateInstance()
        {
            return (EquipCell31)UIPackage.CreateObject("UIRes", "EquipCell31");
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
            Eff23 = (GLoader)GetChild("Eff23");
            Eff13 = (GLoader)GetChild("Eff13");
            bagsLod = (GLoader)GetChild("bagsLod");
            IconXY = (GTextField)GetChild("IconXY");
            EffectXY = (GTextField)GetChild("EffectXY");
            StarLevel = (GTextField)GetChild("StarLevel");
        }
    }
}