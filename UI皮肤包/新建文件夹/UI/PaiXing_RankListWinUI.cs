/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class PaiXing_RankListWinUI : GComponent
    {
        public GImage RankListWin;
        public GGraph ModalLayer;
        public GButton BtnStorageUIClose;
        public GButton DA2ERadioButton1;
        public GButton DA2ERadioButton2;
        public GButton DA2ERadioButton3;
        public GButton DA2ERadioButton4;
        public GList RankListGrid1;
        public GTextField ChatEdit3;
        public GTextField RankOnselfText;
        public GTextField ChatEdit5;
        public GTextField RankGuildText;
        public GComponent role;
        public GButton RankLookRoleBtn;
        public GButton RankTipsBtn;
        public GButton DA2ERadioButton5;
        public GButton DA2ERadioButton6;
        public GButton DA2ERadioButton7;
        public GButton DA2ERadioButton8;
        public GButton DA2ERadioButton9;
        public GButton DA2ERadioButton10;
        public const string URL = "ui://jyvofh5ekn5zzz";

        public static PaiXing_RankListWinUI CreateInstance()
        {
            return (PaiXing_RankListWinUI)UIPackage.CreateObject("UI", "排行_RankListWinUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            RankListWin = (GImage)GetChild("RankListWin");
            ModalLayer = (GGraph)GetChild("ModalLayer");
            BtnStorageUIClose = (GButton)GetChild("BtnStorageUIClose");
            DA2ERadioButton1 = (GButton)GetChild("DA2ERadioButton1");
            DA2ERadioButton2 = (GButton)GetChild("DA2ERadioButton2");
            DA2ERadioButton3 = (GButton)GetChild("DA2ERadioButton3");
            DA2ERadioButton4 = (GButton)GetChild("DA2ERadioButton4");
            RankListGrid1 = (GList)GetChild("RankListGrid1");
            ChatEdit3 = (GTextField)GetChild("ChatEdit3");
            RankOnselfText = (GTextField)GetChild("RankOnselfText");
            ChatEdit5 = (GTextField)GetChild("ChatEdit5");
            RankGuildText = (GTextField)GetChild("RankGuildText");
            role = (GComponent)GetChild("role");
            RankLookRoleBtn = (GButton)GetChild("RankLookRoleBtn");
            RankTipsBtn = (GButton)GetChild("RankTipsBtn");
            DA2ERadioButton5 = (GButton)GetChild("DA2ERadioButton5");
            DA2ERadioButton6 = (GButton)GetChild("DA2ERadioButton6");
            DA2ERadioButton7 = (GButton)GetChild("DA2ERadioButton7");
            DA2ERadioButton8 = (GButton)GetChild("DA2ERadioButton8");
            DA2ERadioButton9 = (GButton)GetChild("DA2ERadioButton9");
            DA2ERadioButton10 = (GButton)GetChild("DA2ERadioButton10");
        }
    }
}