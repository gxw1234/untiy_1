/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class XiaJia_SoldOutGoodsUI : GComponent
    {
        public GImage SoldOutGoodsUI;
        public GComponent frame;
        public GImage DA2EIMAGE3;
        public GImage DA2EIMAGE4;
        public GTextField SoldOutGoodsNames;
        public GTextField SoldOutGoodsTimes;
        public GTextField ChatEdit48;
        public GTextField ChatEdit49;
        public GComponent SoldOutGoodsStWin;
        public GComponent SoldOutGoodsMPWin;
        public GButton SoldOutGCancleBtn;
        public GButton SoldOutGBuyBtn;
        public GTextField SoldOutGdsStateEdit;
        public GTextField SoldOutGoodsAdEdits;
        public GButton DA2ESimpleButton11;
        public GButton DA2ESimpleButton12;
        public GTextField ChatEdit34;
        public GComponent SoldOutGoodsNPWin;
        public GButton DA2ESimpleButton5;
        public GComponent SoldOutGoodsWin;
        public GTextField SoldOutGoodsNums;
        public const string URL = "ui://jyvofh5ekn5z13p";

        public static XiaJia_SoldOutGoodsUI CreateInstance()
        {
            return (XiaJia_SoldOutGoodsUI)UIPackage.CreateObject("UI", "下架_SoldOutGoodsUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            SoldOutGoodsUI = (GImage)GetChild("SoldOutGoodsUI");
            frame = (GComponent)GetChild("frame");
            DA2EIMAGE3 = (GImage)GetChild("DA2EIMAGE3");
            DA2EIMAGE4 = (GImage)GetChild("DA2EIMAGE4");
            SoldOutGoodsNames = (GTextField)GetChild("SoldOutGoodsNames");
            SoldOutGoodsTimes = (GTextField)GetChild("SoldOutGoodsTimes");
            ChatEdit48 = (GTextField)GetChild("ChatEdit48");
            ChatEdit49 = (GTextField)GetChild("ChatEdit49");
            SoldOutGoodsStWin = (GComponent)GetChild("SoldOutGoodsStWin");
            SoldOutGoodsMPWin = (GComponent)GetChild("SoldOutGoodsMPWin");
            SoldOutGCancleBtn = (GButton)GetChild("SoldOutGCancleBtn");
            SoldOutGBuyBtn = (GButton)GetChild("SoldOutGBuyBtn");
            SoldOutGdsStateEdit = (GTextField)GetChild("SoldOutGdsStateEdit");
            SoldOutGoodsAdEdits = (GTextField)GetChild("SoldOutGoodsAdEdits");
            DA2ESimpleButton11 = (GButton)GetChild("DA2ESimpleButton11");
            DA2ESimpleButton12 = (GButton)GetChild("DA2ESimpleButton12");
            ChatEdit34 = (GTextField)GetChild("ChatEdit34");
            SoldOutGoodsNPWin = (GComponent)GetChild("SoldOutGoodsNPWin");
            DA2ESimpleButton5 = (GButton)GetChild("DA2ESimpleButton5");
            SoldOutGoodsWin = (GComponent)GetChild("SoldOutGoodsWin");
            SoldOutGoodsNums = (GTextField)GetChild("SoldOutGoodsNums");
        }
    }
}