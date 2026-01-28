/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class DUserShopDlg : GComponent
    {
        public GImage BG;
        public GComponent frame;
        public GButton CloseButton;
        public GImage bg_line;
        public GImage input_bg;
        public GImage price2_bg;
        public GButton SearchButton;
        public GComboBox huobi;
        public GComboBox leibie;
        public GComboBox Sort_L;
        public GButton LeftButton;
        public GButton RightButton;
        public GButton EndButton;
        public GButton StartButton;
        public GImage page_bg;
        public GButton FirstButton;
        public GButton BackButton;
        public GTextInput input_search;
        public GTextInput price1;
        public GTextInput price2;
        public GTextField pageNum;
        public GTextField Title;
        public GTextField ss;
        public GTextField serchTxt;
        public GTextField priceTxt;
        public GTextField sortTxt;
        public GTextField GoldTxt;
        public GTextField Txt1;
        public GTextField Txt2;
        public GTextField Txt3;
        public GTextField Txt4;
        public GTextField shopName;
        public GTextField Ite;
        public GTextField Ite2;
        public GTextField Ite3;
        public GTextField Ite4;
        public GTextField Ite5;
        public GList ListView;
        public const string URL = "ui://jyvofh5em9og1u";

        public static DUserShopDlg CreateInstance()
        {
            return (DUserShopDlg)UIPackage.CreateObject("UI", "DUserShopDlg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            BG = (GImage)GetChild("BG");
            frame = (GComponent)GetChild("frame");
            CloseButton = (GButton)GetChild("CloseButton");
            bg_line = (GImage)GetChild("bg_line");
            input_bg = (GImage)GetChild("input_bg");
            price2_bg = (GImage)GetChild("price2_bg");
            SearchButton = (GButton)GetChild("SearchButton");
            huobi = (GComboBox)GetChild("huobi");
            leibie = (GComboBox)GetChild("leibie");
            Sort_L = (GComboBox)GetChild("Sort_L");
            LeftButton = (GButton)GetChild("LeftButton");
            RightButton = (GButton)GetChild("RightButton");
            EndButton = (GButton)GetChild("EndButton");
            StartButton = (GButton)GetChild("StartButton");
            page_bg = (GImage)GetChild("page_bg");
            FirstButton = (GButton)GetChild("FirstButton");
            BackButton = (GButton)GetChild("BackButton");
            input_search = (GTextInput)GetChild("input_search");
            price1 = (GTextInput)GetChild("price1");
            price2 = (GTextInput)GetChild("price2");
            pageNum = (GTextField)GetChild("pageNum");
            Title = (GTextField)GetChild("Title");
            ss = (GTextField)GetChild("ss");
            serchTxt = (GTextField)GetChild("serchTxt");
            priceTxt = (GTextField)GetChild("priceTxt");
            sortTxt = (GTextField)GetChild("sortTxt");
            GoldTxt = (GTextField)GetChild("GoldTxt");
            Txt1 = (GTextField)GetChild("Txt1");
            Txt2 = (GTextField)GetChild("Txt2");
            Txt3 = (GTextField)GetChild("Txt3");
            Txt4 = (GTextField)GetChild("Txt4");
            shopName = (GTextField)GetChild("shopName");
            Ite = (GTextField)GetChild("Ite");
            Ite2 = (GTextField)GetChild("Ite2");
            Ite3 = (GTextField)GetChild("Ite3");
            Ite4 = (GTextField)GetChild("Ite4");
            Ite5 = (GTextField)GetChild("Ite5");
            ListView = (GList)GetChild("ListView");
        }
    }
}