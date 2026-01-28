/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CLeftpage1 : GComponent
    {
        public Controller c1;
        public GImage divisionbg;
        public GImage n10;
        public Button1 RoleBtn1;
        public Button2 MoneyBtn2;
        public Button5 RoleToMe;
        public Button4 MoneyToMe;
        public Page1Com Page1Com;
        public Page2Com Page2Com;
        public wenhao1 DealExplainBtn;
        public tixianbtn TakeMoenBtn;
        public GTextField n13;
        public GTextField MoneyJYBText;
        public GImage footerBg;
        public DealBtnPageUp DealBtnPageUp;
        public DealBtnPageDown DealBtnPageDown;
        public GTextField FooterNums;
        public const string URL = "ui://jk0io98jj3e21bp";

        public static CLeftpage1 CreateInstance()
        {
            return (CLeftpage1)UIPackage.CreateObject("UIRes", "CLeftpage1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            c1 = GetController("c1");
            divisionbg = (GImage)GetChild("divisionbg");
            n10 = (GImage)GetChild("n10");
            RoleBtn1 = (Button1)GetChild("RoleBtn1");
            MoneyBtn2 = (Button2)GetChild("MoneyBtn2");
            RoleToMe = (Button5)GetChild("RoleToMe");
            MoneyToMe = (Button4)GetChild("MoneyToMe");
            Page1Com = (Page1Com)GetChild("Page1Com");
            Page2Com = (Page2Com)GetChild("Page2Com");
            DealExplainBtn = (wenhao1)GetChild("DealExplainBtn");
            TakeMoenBtn = (tixianbtn)GetChild("TakeMoenBtn");
            n13 = (GTextField)GetChild("n13");
            MoneyJYBText = (GTextField)GetChild("MoneyJYBText");
            footerBg = (GImage)GetChild("footerBg");
            DealBtnPageUp = (DealBtnPageUp)GetChild("DealBtnPageUp");
            DealBtnPageDown = (DealBtnPageDown)GetChild("DealBtnPageDown");
            FooterNums = (GTextField)GetChild("FooterNums");
        }
    }
}