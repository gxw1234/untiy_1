/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class QuickEquipNoteUI : GComponent
    {
        public GImage QuickEquipNoteUI;
        public frame frame;
        public QEquipBtnClose QEquipBtnClose;
        public GTextField QEquipTitleNames;
        public EquipNoteShowLoad EquipNoteShowLoad;
        public GTextField QEquipNames;
        public QDressEqpBtn QDressEqpBtn;
        public GTextField QEquipTimeEdit;
        public const string URL = "ui://jk0io98jv9b1g7";

        public static QuickEquipNoteUI CreateInstance()
        {
            return (QuickEquipNoteUI)UIPackage.CreateObject("UIRes", "QuickEquipNoteUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            QuickEquipNoteUI = (GImage)GetChild("QuickEquipNoteUI");
            frame = (frame)GetChild("frame");
            QEquipBtnClose = (QEquipBtnClose)GetChild("QEquipBtnClose");
            QEquipTitleNames = (GTextField)GetChild("QEquipTitleNames");
            EquipNoteShowLoad = (EquipNoteShowLoad)GetChild("EquipNoteShowLoad");
            QEquipNames = (GTextField)GetChild("QEquipNames");
            QDressEqpBtn = (QDressEqpBtn)GetChild("QDressEqpBtn");
            QEquipTimeEdit = (GTextField)GetChild("QEquipTimeEdit");
        }
    }
}