/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ChuShouLeiXing_PricewindUI : GComponent
    {
        public Controller CRadios;
        public GImage Pricewind;
        public GTextField ChatEdit1;
        public GTextInput VclEditPrice;
        public GButton BtnDePresident;
        public GButton BtnPresident;
        public GTextField EditText1;
        public GTextField EditText;
        public GButton BtnAffirm;
        public GButton BtnItemCancle;
        public GButton DBagClose;
        public const string URL = "ui://jyvofh5ej3e21gm";

        public static ChuShouLeiXing_PricewindUI CreateInstance()
        {
            return (ChuShouLeiXing_PricewindUI)UIPackage.CreateObject("UI", "出售类型_PricewindUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CRadios = GetController("CRadios");
            Pricewind = (GImage)GetChild("Pricewind");
            ChatEdit1 = (GTextField)GetChild("ChatEdit1");
            VclEditPrice = (GTextInput)GetChild("VclEditPrice");
            BtnDePresident = (GButton)GetChild("BtnDePresident");
            BtnPresident = (GButton)GetChild("BtnPresident");
            EditText1 = (GTextField)GetChild("EditText1");
            EditText = (GTextField)GetChild("EditText");
            BtnAffirm = (GButton)GetChild("BtnAffirm");
            BtnItemCancle = (GButton)GetChild("BtnItemCancle");
            DBagClose = (GButton)GetChild("DBagClose");
        }
    }
}