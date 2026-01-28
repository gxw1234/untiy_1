/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BuyPanel : GComponent
    {
        public GImage bg;
        public GList ListView;
        public GTextField serchTxt;
        public GTextField ss;
        public GTextField priceTxt;
        public GTextField GoldTxt;
        public Gategory2 huobi;
        public Gategory2 leibie;
        public SearchButton SearchButton;
        public GImage input_bg;
        public GImage price2_bg;
        public GTextInput input_search;
        public GTextInput price1;
        public GTextInput price2;
        public LeftButton LeftButton;
        public RightButton RightButton;
        public EndButton EndButton;
        public StartButton StartButton;
        public GImage page_bg;
        public GTextField pageNum;
        public FirstButton FirstButton;
        public Gateroty3 Sort_L;
        public GTextField sortTxt;
        public GTextField ShopName;
        public GTextField PriceName;
        public GTextField HostShopName;
        public GTextField HostName;
        public GTextField LeiName;
        public GTextField BuyTxt;
        public const string URL = "ui://jk0io98jm9og11";

        public static BuyPanel CreateInstance()
        {
            return (BuyPanel)UIPackage.CreateObject("UIRes", "BuyPanel");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            ListView = (GList)GetChild("ListView");
            serchTxt = (GTextField)GetChild("serchTxt");
            ss = (GTextField)GetChild("ss");
            priceTxt = (GTextField)GetChild("priceTxt");
            GoldTxt = (GTextField)GetChild("GoldTxt");
            huobi = (Gategory2)GetChild("huobi");
            leibie = (Gategory2)GetChild("leibie");
            SearchButton = (SearchButton)GetChild("SearchButton");
            input_bg = (GImage)GetChild("input_bg");
            price2_bg = (GImage)GetChild("price2_bg");
            input_search = (GTextInput)GetChild("input_search");
            price1 = (GTextInput)GetChild("price1");
            price2 = (GTextInput)GetChild("price2");
            LeftButton = (LeftButton)GetChild("LeftButton");
            RightButton = (RightButton)GetChild("RightButton");
            EndButton = (EndButton)GetChild("EndButton");
            StartButton = (StartButton)GetChild("StartButton");
            page_bg = (GImage)GetChild("page_bg");
            pageNum = (GTextField)GetChild("pageNum");
            FirstButton = (FirstButton)GetChild("FirstButton");
            Sort_L = (Gateroty3)GetChild("Sort_L");
            sortTxt = (GTextField)GetChild("sortTxt");
            ShopName = (GTextField)GetChild("ShopName");
            PriceName = (GTextField)GetChild("PriceName");
            HostShopName = (GTextField)GetChild("HostShopName");
            HostName = (GTextField)GetChild("HostName");
            LeiName = (GTextField)GetChild("LeiName");
            BuyTxt = (GTextField)GetChild("BuyTxt");
        }
    }
}