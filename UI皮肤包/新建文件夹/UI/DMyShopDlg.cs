/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class DMyShopDlg : GComponent
    {
        public GImage bg;
        public GComponent frame;
        public GTextField Title;
        public GButton cs1;
        public GButton cs2;
        public GButton cs3;
        public GButton cs4;
        public GButton cs5;
        public GButton Stall;
        public GComponent Page1;
        public GComponent Page2;
        public GComponent Page3;
        public GComponent Page4;
        public GComponent Page5;
        public GButton LeftButton;
        public GButton RightButton;
        public GButton EndButton;
        public GButton StartButton;
        public GImage page_bg;
        public GTextField pageNum;
        public GButton FirstButton;
        public GImage input_bg;
        public GTextInput input_search;
        public GButton SearchButton;
        public GComboBox point_L;
        public GTextField pointTxt;
        public GTextField serchTxt;
        public GTextField priceTxt;
        public GTextField GoldTxt;
        public GComboBox huobi;
        public GComboBox leibie;
        public GImage price2_bg;
        public GTextInput price1;
        public GTextInput price2;
        public GComboBox Sort_L;
        public GTextField sortTxt;
        public GComboBox ItemType;
        public GComboBox weizhi_L;
        public GTextField weizhi1;
        public GTextField leibie2;
        public GComboBox leixing_L;
        public GTextField leixing;
        public GTextField jiage;
        public GTextField Desc;
        public GImage jiage_bg;
        public GTextInput input_jiage;
        public GImage itembg;
        public GComponent EquipCell;
        public GButton jishou;
        public GButton CloseButton;
        public const string URL = "ui://jyvofh5em9og1e";

        public static DMyShopDlg CreateInstance()
        {
            return (DMyShopDlg)UIPackage.CreateObject("UI", "DMyShopDlg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            frame = (GComponent)GetChild("frame");
            Title = (GTextField)GetChild("Title");
            cs1 = (GButton)GetChild("cs1");
            cs2 = (GButton)GetChild("cs2");
            cs3 = (GButton)GetChild("cs3");
            cs4 = (GButton)GetChild("cs4");
            cs5 = (GButton)GetChild("cs5");
            Stall = (GButton)GetChild("Stall");
            Page1 = (GComponent)GetChild("Page1");
            Page2 = (GComponent)GetChild("Page2");
            Page3 = (GComponent)GetChild("Page3");
            Page4 = (GComponent)GetChild("Page4");
            Page5 = (GComponent)GetChild("Page5");
            LeftButton = (GButton)GetChild("LeftButton");
            RightButton = (GButton)GetChild("RightButton");
            EndButton = (GButton)GetChild("EndButton");
            StartButton = (GButton)GetChild("StartButton");
            page_bg = (GImage)GetChild("page_bg");
            pageNum = (GTextField)GetChild("pageNum");
            FirstButton = (GButton)GetChild("FirstButton");
            input_bg = (GImage)GetChild("input_bg");
            input_search = (GTextInput)GetChild("input_search");
            SearchButton = (GButton)GetChild("SearchButton");
            point_L = (GComboBox)GetChild("point_L");
            pointTxt = (GTextField)GetChild("pointTxt");
            serchTxt = (GTextField)GetChild("serchTxt");
            priceTxt = (GTextField)GetChild("priceTxt");
            GoldTxt = (GTextField)GetChild("GoldTxt");
            huobi = (GComboBox)GetChild("huobi");
            leibie = (GComboBox)GetChild("leibie");
            price2_bg = (GImage)GetChild("price2_bg");
            price1 = (GTextInput)GetChild("price1");
            price2 = (GTextInput)GetChild("price2");
            Sort_L = (GComboBox)GetChild("Sort_L");
            sortTxt = (GTextField)GetChild("sortTxt");
            ItemType = (GComboBox)GetChild("ItemType");
            weizhi_L = (GComboBox)GetChild("weizhi_L");
            weizhi1 = (GTextField)GetChild("weizhi1");
            leibie2 = (GTextField)GetChild("leibie2");
            leixing_L = (GComboBox)GetChild("leixing_L");
            leixing = (GTextField)GetChild("leixing");
            jiage = (GTextField)GetChild("jiage");
            Desc = (GTextField)GetChild("Desc");
            jiage_bg = (GImage)GetChild("jiage_bg");
            input_jiage = (GTextInput)GetChild("input_jiage");
            itembg = (GImage)GetChild("itembg");
            EquipCell = (GComponent)GetChild("EquipCell");
            jishou = (GButton)GetChild("jishou");
            CloseButton = (GButton)GetChild("CloseButton");
        }
    }
}