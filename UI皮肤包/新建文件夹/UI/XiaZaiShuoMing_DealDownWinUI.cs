/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class XiaZaiShuoMing_DealDownWinUI : GComponent
    {
        public GImage n0;
        public GButton DealDownCloseBtn;
        public GTextField n2;
        public GButton DealDownSBtn;
        public const string URL = "ui://jyvofh5e11icn1ph";

        public static XiaZaiShuoMing_DealDownWinUI CreateInstance()
        {
            return (XiaZaiShuoMing_DealDownWinUI)UIPackage.CreateObject("UI", "下载说明_DealDownWinUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            DealDownCloseBtn = (GButton)GetChild("DealDownCloseBtn");
            n2 = (GTextField)GetChild("n2");
            DealDownSBtn = (GButton)GetChild("DealDownSBtn");
        }
    }
}