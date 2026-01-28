/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class JiShouChengGong_DealRelateWinUI : GComponent
    {
        public GImage n0;
        public GTextField n2;
        public GButton ConsignSBtn;
        public const string URL = "ui://jyvofh5e11icn1pi";

        public static JiShouChengGong_DealRelateWinUI CreateInstance()
        {
            return (JiShouChengGong_DealRelateWinUI)UIPackage.CreateObject("UI", "寄售成功_DealRelateWinUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            n2 = (GTextField)GetChild("n2");
            ConsignSBtn = (GButton)GetChild("ConsignSBtn");
        }
    }
}