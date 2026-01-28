/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DStateWindow : GComponent
    {
        public GImage DStateWindow;
        public DBtnGold DBtnGold;
        public GImage DA2EIMAGE3;
        public JinBiWin JinBiWin;
        public YuanBaoWin YuanBaoWin;
        public JinPiaoWin JinPiaoWin;
        public YouXiDianWin YouXiDianWin;
        public RongYuWin RongYuWin;
        public JinGangShiWin JinGangShiWin;
        public LingFuWin LingFuWin;
        public XinYouXiDianWin XinYouXiDianWin;
        public ShengWangWin ShengWangWin;
        public Top_Page1 Top_Page1;
        public Top_Page2 Top_Page2;
        public Top_Page3 Top_Page3;
        public Top_Page4 Top_Page4;
        public Top_Page5 Top_Page5;
        public GTextField Desc;
        public const string URL = "ui://jk0io98jv9b16t";

        public static DStateWindow CreateInstance()
        {
            return (DStateWindow)UIPackage.CreateObject("UIRes", "DStateWindow");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DStateWindow = (GImage)GetChild("DStateWindow");
            DBtnGold = (DBtnGold)GetChild("DBtnGold");
            DA2EIMAGE3 = (GImage)GetChild("DA2EIMAGE3");
            JinBiWin = (JinBiWin)GetChild("JinBiWin");
            YuanBaoWin = (YuanBaoWin)GetChild("YuanBaoWin");
            JinPiaoWin = (JinPiaoWin)GetChild("JinPiaoWin");
            YouXiDianWin = (YouXiDianWin)GetChild("YouXiDianWin");
            RongYuWin = (RongYuWin)GetChild("RongYuWin");
            JinGangShiWin = (JinGangShiWin)GetChild("JinGangShiWin");
            LingFuWin = (LingFuWin)GetChild("LingFuWin");
            XinYouXiDianWin = (XinYouXiDianWin)GetChild("XinYouXiDianWin");
            ShengWangWin = (ShengWangWin)GetChild("ShengWangWin");
            Top_Page1 = (Top_Page1)GetChild("Top_Page1");
            Top_Page2 = (Top_Page2)GetChild("Top_Page2");
            Top_Page3 = (Top_Page3)GetChild("Top_Page3");
            Top_Page4 = (Top_Page4)GetChild("Top_Page4");
            Top_Page5 = (Top_Page5)GetChild("Top_Page5");
            Desc = (GTextField)GetChild("Desc");
        }
    }
}