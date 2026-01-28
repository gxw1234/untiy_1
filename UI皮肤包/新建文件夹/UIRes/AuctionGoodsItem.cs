/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class AuctionGoodsItem : GButton
    {
        public Controller button;
        public GImage Img629t8u;
        public GTextField AuctionGoodsNames;
        public GTextField AuctionGoodTimes;
        public GTextField ChatEdit28;
        public GLoader DA2ELoader11;
        public GLoader DA2ELoader12;
        public DA2ESimpleButton3 DA2ESimpleButton3;
        public DA2ESimpleButton4 DA2ESimpleButton4;
        public AuctionGoodsWin AuctionGoodsWin;
        public DA2EWindow5 DA2EWindow5;
        public DA2EWindow7 DA2EWindow7;
        public const string URL = "ui://jk0io98jkn5z139";

        public static AuctionGoodsItem CreateInstance()
        {
            return (AuctionGoodsItem)UIPackage.CreateObject("UIRes", "AuctionGoodsItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img629t8u = (GImage)GetChild("Img629t8u");
            AuctionGoodsNames = (GTextField)GetChild("AuctionGoodsNames");
            AuctionGoodTimes = (GTextField)GetChild("AuctionGoodTimes");
            ChatEdit28 = (GTextField)GetChild("ChatEdit28");
            DA2ELoader11 = (GLoader)GetChild("DA2ELoader11");
            DA2ELoader12 = (GLoader)GetChild("DA2ELoader12");
            DA2ESimpleButton3 = (DA2ESimpleButton3)GetChild("DA2ESimpleButton3");
            DA2ESimpleButton4 = (DA2ESimpleButton4)GetChild("DA2ESimpleButton4");
            AuctionGoodsWin = (AuctionGoodsWin)GetChild("AuctionGoodsWin");
            DA2EWindow5 = (DA2EWindow5)GetChild("DA2EWindow5");
            DA2EWindow7 = (DA2EWindow7)GetChild("DA2EWindow7");
        }
    }
}