/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnsWindow : GComponent
    {
        public DBtnSetting DBtnSetting;
        public DBtnExit DBtnExit;
        public DBtnFriends DBtnFriends;
        public DBtnGuild DBtnGuild;
        public DBtnGroup DBtnGroup;
        public DBtnAuctionGuild DBtnAuctionGuild;
        public DA2ESimpleButton14 DA2ESimpleButton14;
        public DA2ESimpleButton15 DA2ESimpleButton15;
        public DBtnShop DBtnShop;
        public DBtnStalling DBtnStalling;
        public DBtnFashionDress DBtnFashionDress;
        public BottomDealBankBtn BottomDealBankBtn;
        public DBtnPet n4;
        public DBtnMounts n5;
        public DBtnMaster n6;
        public DBtnCouple n7;
        public DBtnFish n8;
        public DBtnTrade n9;
        public Title n10;
        public Smelters n11;
        public Invent n12;
        public Composition n13;
        public Cook n14;
        public const string URL = "ui://jk0io98jk02tn1up";

        public static DBtnsWindow CreateInstance()
        {
            return (DBtnsWindow)UIPackage.CreateObject("UIRes", "DBtnsWindow");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBtnSetting = (DBtnSetting)GetChild("DBtnSetting");
            DBtnExit = (DBtnExit)GetChild("DBtnExit");
            DBtnFriends = (DBtnFriends)GetChild("DBtnFriends");
            DBtnGuild = (DBtnGuild)GetChild("DBtnGuild");
            DBtnGroup = (DBtnGroup)GetChild("DBtnGroup");
            DBtnAuctionGuild = (DBtnAuctionGuild)GetChild("DBtnAuctionGuild");
            DA2ESimpleButton14 = (DA2ESimpleButton14)GetChild("DA2ESimpleButton14");
            DA2ESimpleButton15 = (DA2ESimpleButton15)GetChild("DA2ESimpleButton15");
            DBtnShop = (DBtnShop)GetChild("DBtnShop");
            DBtnStalling = (DBtnStalling)GetChild("DBtnStalling");
            DBtnFashionDress = (DBtnFashionDress)GetChild("DBtnFashionDress");
            BottomDealBankBtn = (BottomDealBankBtn)GetChild("BottomDealBankBtn");
            n4 = (DBtnPet)GetChild("n4");
            n5 = (DBtnMounts)GetChild("n5");
            n6 = (DBtnMaster)GetChild("n6");
            n7 = (DBtnCouple)GetChild("n7");
            n8 = (DBtnFish)GetChild("n8");
            n9 = (DBtnTrade)GetChild("n9");
            n10 = (Title)GetChild("n10");
            n11 = (Smelters)GetChild("n11");
            n12 = (Invent)GetChild("n12");
            n13 = (Composition)GetChild("n13");
            n14 = (Cook)GetChild("n14");
        }
    }
}