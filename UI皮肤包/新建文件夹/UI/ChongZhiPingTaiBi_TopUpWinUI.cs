/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ChongZhiPingTaiBi_TopUpWinUI : GComponent
    {
        public GImage bg;
        public GComponent frame;
        public GGraph ModalLayer;
        public GButton TopUpCloseBtn;
        public GTextField n3;
        public GTextField RoleName;
        public GTextField n5;
        public GTextField ServerName;
        public GTextField n7;
        public GList MoneyTypeG;
        public GRichTextField n16;
        public GRichTextField text_myptb;
        public GButton NotarizeRechargeBtn;
        public const string URL = "ui://jyvofh5eorc80";

        public static ChongZhiPingTaiBi_TopUpWinUI CreateInstance()
        {
            return (ChongZhiPingTaiBi_TopUpWinUI)UIPackage.CreateObject("UI", "充值平台币_TopUpWinUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            frame = (GComponent)GetChild("frame");
            ModalLayer = (GGraph)GetChild("ModalLayer");
            TopUpCloseBtn = (GButton)GetChild("TopUpCloseBtn");
            n3 = (GTextField)GetChild("n3");
            RoleName = (GTextField)GetChild("RoleName");
            n5 = (GTextField)GetChild("n5");
            ServerName = (GTextField)GetChild("ServerName");
            n7 = (GTextField)GetChild("n7");
            MoneyTypeG = (GList)GetChild("MoneyTypeG");
            n16 = (GRichTextField)GetChild("n16");
            text_myptb = (GRichTextField)GetChild("text_myptb");
            NotarizeRechargeBtn = (GButton)GetChild("NotarizeRechargeBtn");
        }
    }
}