/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class JiaoYiShuoMing_DealConsignSWinUI : GComponent
    {
        public GImage n0;
        public GButton DealRelatedCloseBtn;
        public GTextField n2;
        public GButton DealRelatedBtn;
        public const string URL = "ui://jyvofh5e11icn1pg";

        public static JiaoYiShuoMing_DealConsignSWinUI CreateInstance()
        {
            return (JiaoYiShuoMing_DealConsignSWinUI)UIPackage.CreateObject("UI", "交易说明_DealConsignSWinUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            DealRelatedCloseBtn = (GButton)GetChild("DealRelatedCloseBtn");
            n2 = (GTextField)GetChild("n2");
            DealRelatedBtn = (GButton)GetChild("DealRelatedBtn");
        }
    }
}