/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class TiShi_CommonHitUI : GComponent
    {
        public GImage CommonHitUI;
        public GRichTextField DTips;
        public GButton DBtnConfirm;
        public GButton DBtnCancel;
        public GGraph DlgEditTextLine;
        public GTextInput DlgEditText;
        public const string URL = "ui://jyvofh5ej3e21l6";

        public static TiShi_CommonHitUI CreateInstance()
        {
            return (TiShi_CommonHitUI)UIPackage.CreateObject("UI", "提示_CommonHitUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CommonHitUI = (GImage)GetChild("CommonHitUI");
            DTips = (GRichTextField)GetChild("DTips");
            DBtnConfirm = (GButton)GetChild("DBtnConfirm");
            DBtnCancel = (GButton)GetChild("DBtnCancel");
            DlgEditTextLine = (GGraph)GetChild("DlgEditTextLine");
            DlgEditText = (GTextInput)GetChild("DlgEditText");
        }
    }
}