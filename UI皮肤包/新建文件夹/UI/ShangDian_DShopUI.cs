/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ShangDian_DShopUI : GComponent
    {
        public Controller CRadios;
        public GImage DShop;
        public GComponent frame;
        public GRichTextField ItemShowInfo;
        public GComponent ItemCell1;
        public GComponent ItemCell2;
        public GComponent ItemCell3;
        public GComponent ItemCell4;
        public GComponent ItemCell5;
        public GComponent ItemCell6;
        public GComponent ItemCell7;
        public GComponent ItemCell8;
        public GComponent ItemCell9;
        public GComponent ItemCell10;
        public GButton BtnBuy;
        public GButton BtnPresent;
        public GComponent ItemCell11;
        public GComponent ItemCell12;
        public GComponent ItemCell13;
        public GComponent ItemCell14;
        public GComponent ItemCell15;
        public GButton BtnClose;
        public GButton BtnPageUp;
        public GButton BtnPageDown;
        public GButton BtnStorageUIClose;
        public GImage PageBackground;
        public GTextField ChatEdit1;
        public GButton DA2ERadioButton1;
        public GButton DA2ERadioButton2;
        public GButton DA2ERadioButton3;
        public GButton DA2ERadioButton4;
        public GButton DA2ERadioButton5;
        public GImage ShopFontImg;
        public GGraph ModalLayer;
        public const string URL = "ui://jyvofh5ekn5zsf";

        public static ShangDian_DShopUI CreateInstance()
        {
            return (ShangDian_DShopUI)UIPackage.CreateObject("UI", "商店_DShopUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CRadios = GetController("CRadios");
            DShop = (GImage)GetChild("DShop");
            frame = (GComponent)GetChild("frame");
            ItemShowInfo = (GRichTextField)GetChild("ItemShowInfo");
            ItemCell1 = (GComponent)GetChild("ItemCell1");
            ItemCell2 = (GComponent)GetChild("ItemCell2");
            ItemCell3 = (GComponent)GetChild("ItemCell3");
            ItemCell4 = (GComponent)GetChild("ItemCell4");
            ItemCell5 = (GComponent)GetChild("ItemCell5");
            ItemCell6 = (GComponent)GetChild("ItemCell6");
            ItemCell7 = (GComponent)GetChild("ItemCell7");
            ItemCell8 = (GComponent)GetChild("ItemCell8");
            ItemCell9 = (GComponent)GetChild("ItemCell9");
            ItemCell10 = (GComponent)GetChild("ItemCell10");
            BtnBuy = (GButton)GetChild("BtnBuy");
            BtnPresent = (GButton)GetChild("BtnPresent");
            ItemCell11 = (GComponent)GetChild("ItemCell11");
            ItemCell12 = (GComponent)GetChild("ItemCell12");
            ItemCell13 = (GComponent)GetChild("ItemCell13");
            ItemCell14 = (GComponent)GetChild("ItemCell14");
            ItemCell15 = (GComponent)GetChild("ItemCell15");
            BtnClose = (GButton)GetChild("BtnClose");
            BtnPageUp = (GButton)GetChild("BtnPageUp");
            BtnPageDown = (GButton)GetChild("BtnPageDown");
            BtnStorageUIClose = (GButton)GetChild("BtnStorageUIClose");
            PageBackground = (GImage)GetChild("PageBackground");
            ChatEdit1 = (GTextField)GetChild("ChatEdit1");
            DA2ERadioButton1 = (GButton)GetChild("DA2ERadioButton1");
            DA2ERadioButton2 = (GButton)GetChild("DA2ERadioButton2");
            DA2ERadioButton3 = (GButton)GetChild("DA2ERadioButton3");
            DA2ERadioButton4 = (GButton)GetChild("DA2ERadioButton4");
            DA2ERadioButton5 = (GButton)GetChild("DA2ERadioButton5");
            ShopFontImg = (GImage)GetChild("ShopFontImg");
            ModalLayer = (GGraph)GetChild("ModalLayer");
        }
    }
}