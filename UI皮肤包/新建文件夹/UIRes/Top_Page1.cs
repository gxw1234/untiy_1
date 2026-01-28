/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Top_Page1 : GComponent
    {
        public YuanBaoWin YuanBaoWin;
        public JinBiWin JinBiWin;
        public JinPiaoWin JinPiaoWin;
        public YouXiDianWin YouXiDianWin;
        public RongYuWin RongYuWin;
        public JinGangShiWin JinGangShiWin;
        public LingFuWin LingFuWin;
        public XinYouXiDianWin XinYouXiDianWin;
        public ShengWangWin ShengWangWin;
        public GTextField FGUIHypertext;
        public const string URL = "ui://jk0io98jjjkzgvn2wk";

        public static Top_Page1 CreateInstance()
        {
            return (Top_Page1)UIPackage.CreateObject("UIRes", "Top_Page1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            YuanBaoWin = (YuanBaoWin)GetChild("YuanBaoWin");
            JinBiWin = (JinBiWin)GetChild("JinBiWin");
            JinPiaoWin = (JinPiaoWin)GetChild("JinPiaoWin");
            YouXiDianWin = (YouXiDianWin)GetChild("YouXiDianWin");
            RongYuWin = (RongYuWin)GetChild("RongYuWin");
            JinGangShiWin = (JinGangShiWin)GetChild("JinGangShiWin");
            LingFuWin = (LingFuWin)GetChild("LingFuWin");
            XinYouXiDianWin = (XinYouXiDianWin)GetChild("XinYouXiDianWin");
            ShengWangWin = (ShengWangWin)GetChild("ShengWangWin");
            FGUIHypertext = (GTextField)GetChild("FGUIHypertext");
        }
    }
}