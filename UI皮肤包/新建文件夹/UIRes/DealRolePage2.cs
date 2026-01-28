/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DealRolePage2 : GComponent
    {
        public GImage n10;
        public GImage n11;
        public GTextField n0;
        public GTextField n3;
        public GTextField n4;
        public GTextInput SellNumTxt;
        public GTextInput SellTallMonTxt;
        public GTextField n12;
        public PutGBtn PutGBtn;
        public GList MoneyTypeGrids;
        public GTextField T_money_assign_title;
        public GImage n16;
        public GTextInput MoneyAssignTxt;
        public GTextField T_money_assign_desc;
        public const string URL = "ui://jk0io98jj3e21c6";

        public static DealRolePage2 CreateInstance()
        {
            return (DealRolePage2)UIPackage.CreateObject("UIRes", "DealRolePage2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n10 = (GImage)GetChild("n10");
            n11 = (GImage)GetChild("n11");
            n0 = (GTextField)GetChild("n0");
            n3 = (GTextField)GetChild("n3");
            n4 = (GTextField)GetChild("n4");
            SellNumTxt = (GTextInput)GetChild("SellNumTxt");
            SellTallMonTxt = (GTextInput)GetChild("SellTallMonTxt");
            n12 = (GTextField)GetChild("n12");
            PutGBtn = (PutGBtn)GetChild("PutGBtn");
            MoneyTypeGrids = (GList)GetChild("MoneyTypeGrids");
            T_money_assign_title = (GTextField)GetChild("T_money_assign_title");
            n16 = (GImage)GetChild("n16");
            MoneyAssignTxt = (GTextInput)GetChild("MoneyAssignTxt");
            T_money_assign_desc = (GTextField)GetChild("T_money_assign_desc");
        }
    }
}