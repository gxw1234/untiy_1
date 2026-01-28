/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class BeiBao_DBagUI : GComponent
    {
        public Controller CRadios;
        public GImage DBag;
        public GImage DA2EIMAGE1;
        public GImage DA2EIMAGE3;
        public GImage DA2EIMAGE2;
        public GComponent frame;
        public GButton DBagClose;
        public GList DBagGrid;
        public GButton btn3;
        public GTextField DGoldText2;
        public GButton DA2EButton1;
        public GButton DBtnQueryBagItems;
        public GButton bagRecoveryBtn;
        public GComponent YuanBaoWin;
        public GComponent JinPiaoWin;
        public GComponent YouXiDianWin;
        public GComponent RongYuWin;
        public GComponent JinGangShiWin;
        public GComponent LingFuWin;
        public GComponent XinYouXiDianWin;
        public GComponent ShengWangWin;
        public GButton DRBStorage;
        public GButton BgRadioBtn1;
        public GButton BgRadioBtn2;
        public GButton BgRadioBtn3;
        public GButton BgRadioBtn4;
        public GButton BgRadioBtn5;
        public GTextField PanelItemTips;
        public GButton BagCustomBtn1;
        public GButton BagCustomBtn2;
        public GButton BagCustomBtn3;
        public GButton BagCustomBtn4;
        public GButton BagCustomBtn5;
        public GComponent YuanBaoBdWin;
        public const string URL = "ui://jyvofh5ev9b15l";

        public static BeiBao_DBagUI CreateInstance()
        {
            return (BeiBao_DBagUI)UIPackage.CreateObject("UI", "背包_DBagUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CRadios = GetController("CRadios");
            DBag = (GImage)GetChild("DBag");
            DA2EIMAGE1 = (GImage)GetChild("DA2EIMAGE1");
            DA2EIMAGE3 = (GImage)GetChild("DA2EIMAGE3");
            DA2EIMAGE2 = (GImage)GetChild("DA2EIMAGE2");
            frame = (GComponent)GetChild("frame");
            DBagClose = (GButton)GetChild("DBagClose");
            DBagGrid = (GList)GetChild("DBagGrid");
            btn3 = (GButton)GetChild("btn3");
            DGoldText2 = (GTextField)GetChild("DGoldText2");
            DA2EButton1 = (GButton)GetChild("DA2EButton1");
            DBtnQueryBagItems = (GButton)GetChild("DBtnQueryBagItems");
            bagRecoveryBtn = (GButton)GetChild("bagRecoveryBtn");
            YuanBaoWin = (GComponent)GetChild("YuanBaoWin");
            JinPiaoWin = (GComponent)GetChild("JinPiaoWin");
            YouXiDianWin = (GComponent)GetChild("YouXiDianWin");
            RongYuWin = (GComponent)GetChild("RongYuWin");
            JinGangShiWin = (GComponent)GetChild("JinGangShiWin");
            LingFuWin = (GComponent)GetChild("LingFuWin");
            XinYouXiDianWin = (GComponent)GetChild("XinYouXiDianWin");
            ShengWangWin = (GComponent)GetChild("ShengWangWin");
            DRBStorage = (GButton)GetChild("DRBStorage");
            BgRadioBtn1 = (GButton)GetChild("BgRadioBtn1");
            BgRadioBtn2 = (GButton)GetChild("BgRadioBtn2");
            BgRadioBtn3 = (GButton)GetChild("BgRadioBtn3");
            BgRadioBtn4 = (GButton)GetChild("BgRadioBtn4");
            BgRadioBtn5 = (GButton)GetChild("BgRadioBtn5");
            PanelItemTips = (GTextField)GetChild("PanelItemTips");
            BagCustomBtn1 = (GButton)GetChild("BagCustomBtn1");
            BagCustomBtn2 = (GButton)GetChild("BagCustomBtn2");
            BagCustomBtn3 = (GButton)GetChild("BagCustomBtn3");
            BagCustomBtn4 = (GButton)GetChild("BagCustomBtn4");
            BagCustomBtn5 = (GButton)GetChild("BagCustomBtn5");
            YuanBaoBdWin = (GComponent)GetChild("YuanBaoBdWin");
        }
    }
}