/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page1BuyWin : GComponent
    {
        public GImage Page1BuyWin;
        public GTextField EditText1;
        public GTextField EditText2;
        public GTextField EditText3;
        public GTextField EditText4;
        public GTextField EditText5;
        public GList DA2EGrid3;
        public Page1RoleStySelect Page1RoleStySelect;
        public Page1GoodsStySelect Page1GoodsStySelect;
        public GTree DA2EGrid6;
        public JinGangShiWin JinGangShiWin;
        public JinPiaoWin JinPiaoWin;
        public LingFuWin LingFuWin;
        public RongYuWin RongYuWin;
        public ShengWangWin ShengWangWin;
        public XinYouXiDianWin XinYouXiDianWin;
        public YouXiDianWin YouXiDianWin;
        public YuanBaoWin YuanBaoWin;
        public JinBiWin JinBiWin;
        public GImage NogoodsImg;
        public const string URL = "ui://jk0io98jkn5z11s";

        public static Page1BuyWin CreateInstance()
        {
            return (Page1BuyWin)UIPackage.CreateObject("UIRes", "Page1BuyWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Page1BuyWin = (GImage)GetChild("Page1BuyWin");
            EditText1 = (GTextField)GetChild("EditText1");
            EditText2 = (GTextField)GetChild("EditText2");
            EditText3 = (GTextField)GetChild("EditText3");
            EditText4 = (GTextField)GetChild("EditText4");
            EditText5 = (GTextField)GetChild("EditText5");
            DA2EGrid3 = (GList)GetChild("DA2EGrid3");
            Page1RoleStySelect = (Page1RoleStySelect)GetChild("Page1RoleStySelect");
            Page1GoodsStySelect = (Page1GoodsStySelect)GetChild("Page1GoodsStySelect");
            DA2EGrid6 = (GTree)GetChild("DA2EGrid6");
            JinGangShiWin = (JinGangShiWin)GetChild("JinGangShiWin");
            JinPiaoWin = (JinPiaoWin)GetChild("JinPiaoWin");
            LingFuWin = (LingFuWin)GetChild("LingFuWin");
            RongYuWin = (RongYuWin)GetChild("RongYuWin");
            ShengWangWin = (ShengWangWin)GetChild("ShengWangWin");
            XinYouXiDianWin = (XinYouXiDianWin)GetChild("XinYouXiDianWin");
            YouXiDianWin = (YouXiDianWin)GetChild("YouXiDianWin");
            YuanBaoWin = (YuanBaoWin)GetChild("YuanBaoWin");
            JinBiWin = (JinBiWin)GetChild("JinBiWin");
            NogoodsImg = (GImage)GetChild("NogoodsImg");
        }
    }
}