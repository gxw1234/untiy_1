/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class GameShopPanel : GComponent
    {
        public GImage bg;
        public GList ListView;
        public GTextField ShopName;
        public GTextField HostName;
        public GTextField Time;
        public GTextField NumTitle;
        public GTextField Total;
        public GTextField State;
        public GTextField Du;
        public GTextField ss;
        public GImage input_bg;
        public GTextInput input_search;
        public SearchButton SearchButton;
        public Gategory Gategory;
        public GTextField sertxt;
        public Gategory Sort;
        public GTextField SortTxt;
        public LeftButton LeftButton;
        public RightButton RightButton;
        public EndButton EndButton;
        public StartButton StartButton;
        public GImage page_bg;
        public GTextField pageNum;
        public FirstButton FirstButton;
        public const string URL = "ui://jk0io98jm9oga";

        public static GameShopPanel CreateInstance()
        {
            return (GameShopPanel)UIPackage.CreateObject("UIRes", "GameShopPanel");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            ListView = (GList)GetChild("ListView");
            ShopName = (GTextField)GetChild("ShopName");
            HostName = (GTextField)GetChild("HostName");
            Time = (GTextField)GetChild("Time");
            NumTitle = (GTextField)GetChild("NumTitle");
            Total = (GTextField)GetChild("Total");
            State = (GTextField)GetChild("State");
            Du = (GTextField)GetChild("Du");
            ss = (GTextField)GetChild("ss");
            input_bg = (GImage)GetChild("input_bg");
            input_search = (GTextInput)GetChild("input_search");
            SearchButton = (SearchButton)GetChild("SearchButton");
            Gategory = (Gategory)GetChild("Gategory");
            sertxt = (GTextField)GetChild("sertxt");
            Sort = (Gategory)GetChild("Sort");
            SortTxt = (GTextField)GetChild("SortTxt");
            LeftButton = (LeftButton)GetChild("LeftButton");
            RightButton = (RightButton)GetChild("RightButton");
            EndButton = (EndButton)GetChild("EndButton");
            StartButton = (StartButton)GetChild("StartButton");
            page_bg = (GImage)GetChild("page_bg");
            pageNum = (GTextField)GetChild("pageNum");
            FirstButton = (FirstButton)GetChild("FirstButton");
        }
    }
}