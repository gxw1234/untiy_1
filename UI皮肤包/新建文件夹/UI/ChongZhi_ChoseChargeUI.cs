/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ChongZhi_ChoseChargeUI : GComponent
    {
        public GImage n0;
        public GButton CodeCloseBtn;
        public GTextField commodityPrice;
        public GTextField commodityName;
        public GButton CodeSureBtn;
        public GImage n20;
        public GList ChosePayList;
        public const string URL = "ui://jyvofh5ekdgun1qb";

        public static ChongZhi_ChoseChargeUI CreateInstance()
        {
            return (ChongZhi_ChoseChargeUI)UIPackage.CreateObject("UI", "充值_ChoseChargeUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            CodeCloseBtn = (GButton)GetChild("CodeCloseBtn");
            commodityPrice = (GTextField)GetChild("commodityPrice");
            commodityName = (GTextField)GetChild("commodityName");
            CodeSureBtn = (GButton)GetChild("CodeSureBtn");
            n20 = (GImage)GetChild("n20");
            ChosePayList = (GList)GetChild("ChosePayList");
        }
    }
}