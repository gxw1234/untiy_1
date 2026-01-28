/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class PaiMaiXing_AuctionGuildUI : GComponent
    {
        public Controller CPages;
        public GImage AuctionGuildUI;
        public GComponent frame;
        public GButton TabBtnBuy;
        public GButton BtnClose;
        public GButton TabBtnSell;
        public GButton TabBtnAuction;
        public GImage ImgGuild;
        public GGraph ModalLayer;
        public GComponent DA2EPage1;
        public GComponent DA2EPage2;
        public GComponent DA2EPage3;
        public const string URL = "ui://jyvofh5ekn5z13a";

        public static PaiMaiXing_AuctionGuildUI CreateInstance()
        {
            return (PaiMaiXing_AuctionGuildUI)UIPackage.CreateObject("UI", "拍卖行_AuctionGuildUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CPages = GetController("CPages");
            AuctionGuildUI = (GImage)GetChild("AuctionGuildUI");
            frame = (GComponent)GetChild("frame");
            TabBtnBuy = (GButton)GetChild("TabBtnBuy");
            BtnClose = (GButton)GetChild("BtnClose");
            TabBtnSell = (GButton)GetChild("TabBtnSell");
            TabBtnAuction = (GButton)GetChild("TabBtnAuction");
            ImgGuild = (GImage)GetChild("ImgGuild");
            ModalLayer = (GGraph)GetChild("ModalLayer");
            DA2EPage1 = (GComponent)GetChild("DA2EPage1");
            DA2EPage2 = (GComponent)GetChild("DA2EPage2");
            DA2EPage3 = (GComponent)GetChild("DA2EPage3");
        }
    }
}