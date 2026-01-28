/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class DuiHuan_TopUpWinUI : GComponent
    {
        public GImage bg;
        public GImage n9;
        public GComponent frame;
        public GGraph ModalLayer;
        public GButton TopUpCloseBtn;
        public GTextField n3;
        public GTextField RoleName;
        public GTextField n5;
        public GTextField ServerName;
        public GTextField n7;
        public GTextField n8;
        public GTextInput InputLimitTxt;
        public GTextField ChangeText;
        public GList MoneyTypeG;
        public GRichTextField n15;
        public GRichTextField n16;
        public GRichTextField text_myptb;
        public GButton NotarizeRechargeBtn;
        public GButton chargePTBBtn;
        public const string URL = "ui://jyvofh5ex8h90";

        public static DuiHuan_TopUpWinUI CreateInstance()
        {
            return (DuiHuan_TopUpWinUI)UIPackage.CreateObject("UI", "兑换_TopUpWinUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            n9 = (GImage)GetChild("n9");
            frame = (GComponent)GetChild("frame");
            ModalLayer = (GGraph)GetChild("ModalLayer");
            TopUpCloseBtn = (GButton)GetChild("TopUpCloseBtn");
            n3 = (GTextField)GetChild("n3");
            RoleName = (GTextField)GetChild("RoleName");
            n5 = (GTextField)GetChild("n5");
            ServerName = (GTextField)GetChild("ServerName");
            n7 = (GTextField)GetChild("n7");
            n8 = (GTextField)GetChild("n8");
            InputLimitTxt = (GTextInput)GetChild("InputLimitTxt");
            ChangeText = (GTextField)GetChild("ChangeText");
            MoneyTypeG = (GList)GetChild("MoneyTypeG");
            n15 = (GRichTextField)GetChild("n15");
            n16 = (GRichTextField)GetChild("n16");
            text_myptb = (GRichTextField)GetChild("text_myptb");
            NotarizeRechargeBtn = (GButton)GetChild("NotarizeRechargeBtn");
            chargePTBBtn = (GButton)GetChild("chargePTBBtn");
        }
    }
}