/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class MailWinStay1 : GComponent
    {
        public GImage MailWinStay1;
        public GList AppendGrids;
        public JinBiWin JinBiWin;
        public JinGangShiWin JinGangShiWin;
        public JinPiaoWin JinPiaoWin;
        public LingFuWin LingFuWin;
        public RongYuWin RongYuWin;
        public ShengWangWin ShengWangWin;
        public XinYouXiDianWin XinYouXiDianWin;
        public YouXiDianWin YouXiDianWin;
        public YuanBaoWin YuanBaoWin;
        public GImage DA2EIMAGE10;
        public const string URL = "ui://jk0io98jkn5zyl";

        public static MailWinStay1 CreateInstance()
        {
            return (MailWinStay1)UIPackage.CreateObject("UIRes", "MailWinStay1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            MailWinStay1 = (GImage)GetChild("MailWinStay1");
            AppendGrids = (GList)GetChild("AppendGrids");
            JinBiWin = (JinBiWin)GetChild("JinBiWin");
            JinGangShiWin = (JinGangShiWin)GetChild("JinGangShiWin");
            JinPiaoWin = (JinPiaoWin)GetChild("JinPiaoWin");
            LingFuWin = (LingFuWin)GetChild("LingFuWin");
            RongYuWin = (RongYuWin)GetChild("RongYuWin");
            ShengWangWin = (ShengWangWin)GetChild("ShengWangWin");
            XinYouXiDianWin = (XinYouXiDianWin)GetChild("XinYouXiDianWin");
            YouXiDianWin = (YouXiDianWin)GetChild("YouXiDianWin");
            YuanBaoWin = (YuanBaoWin)GetChild("YuanBaoWin");
            DA2EIMAGE10 = (GImage)GetChild("DA2EIMAGE10");
        }
    }
}