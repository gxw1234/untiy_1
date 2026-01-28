/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class JiaoYi_DDealDlgUI : GComponent
    {
        public GImage DDealDlg;
        public GTextField DMyName;
        public GTextField DMyGold;
        public GList DDealGrid;
        public GButton BtnDeal;
        public GButton CloseDealBtn;
        public GButton DDGold;
        public const string URL = "ui://jyvofh5ekn5z18t";

        public static JiaoYi_DDealDlgUI CreateInstance()
        {
            return (JiaoYi_DDealDlgUI)UIPackage.CreateObject("UI", "交易_DDealDlgUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DDealDlg = (GImage)GetChild("DDealDlg");
            DMyName = (GTextField)GetChild("DMyName");
            DMyGold = (GTextField)GetChild("DMyGold");
            DDealGrid = (GList)GetChild("DDealGrid");
            BtnDeal = (GButton)GetChild("BtnDeal");
            CloseDealBtn = (GButton)GetChild("CloseDealBtn");
            DDGold = (GButton)GetChild("DDGold");
        }
    }
}