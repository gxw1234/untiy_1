/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ShenQi_JewelryBoxUI : GComponent
    {
        public GComponent frame;
        public GImage JewelryBoxUIBG;
        public GComponent EquipCell30;
        public GComponent EquipCell31;
        public GComponent EquipCell32;
        public GComponent EquipCell33;
        public GComponent EquipCell34;
        public GComponent EquipCell35;
        public GComponent EquipCell36;
        public GComponent EquipCell37;
        public GComponent EquipCell38;
        public GComponent EquipCell39;
        public GComponent EquipCell40;
        public GComponent EquipCell41;
        public GButton DBtnBoxClose;
        public const string URL = "ui://jyvofh5e11icn1pk";

        public static ShenQi_JewelryBoxUI CreateInstance()
        {
            return (ShenQi_JewelryBoxUI)UIPackage.CreateObject("UI", "神器_JewelryBoxUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            frame = (GComponent)GetChild("frame");
            JewelryBoxUIBG = (GImage)GetChild("JewelryBoxUIBG");
            EquipCell30 = (GComponent)GetChild("EquipCell30");
            EquipCell31 = (GComponent)GetChild("EquipCell31");
            EquipCell32 = (GComponent)GetChild("EquipCell32");
            EquipCell33 = (GComponent)GetChild("EquipCell33");
            EquipCell34 = (GComponent)GetChild("EquipCell34");
            EquipCell35 = (GComponent)GetChild("EquipCell35");
            EquipCell36 = (GComponent)GetChild("EquipCell36");
            EquipCell37 = (GComponent)GetChild("EquipCell37");
            EquipCell38 = (GComponent)GetChild("EquipCell38");
            EquipCell39 = (GComponent)GetChild("EquipCell39");
            EquipCell40 = (GComponent)GetChild("EquipCell40");
            EquipCell41 = (GComponent)GetChild("EquipCell41");
            DBtnBoxClose = (GButton)GetChild("DBtnBoxClose");
        }
    }
}