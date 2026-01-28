/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class EquipNoteShowLoad : GComponent
    {
        public GImage QEquipBg;
        public GLoader QEff21;
        public GLoader QEff11;
        public GLoader Qicon;
        public GTextField QEquipEdits;
        public GLoader QEff22;
        public GLoader QEff12;
        public GLoader QEff23;
        public GLoader QEff13;
        public GLoader QEquipLoad;
        public const string URL = "ui://jk0io98jv9b1fw";

        public static EquipNoteShowLoad CreateInstance()
        {
            return (EquipNoteShowLoad)UIPackage.CreateObject("UIRes", "EquipNoteShowLoad");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            QEquipBg = (GImage)GetChild("QEquipBg");
            QEff21 = (GLoader)GetChild("QEff21");
            QEff11 = (GLoader)GetChild("QEff11");
            Qicon = (GLoader)GetChild("Qicon");
            QEquipEdits = (GTextField)GetChild("QEquipEdits");
            QEff22 = (GLoader)GetChild("QEff22");
            QEff12 = (GLoader)GetChild("QEff12");
            QEff23 = (GLoader)GetChild("QEff23");
            QEff13 = (GLoader)GetChild("QEff13");
            QEquipLoad = (GLoader)GetChild("QEquipLoad");
        }
    }
}