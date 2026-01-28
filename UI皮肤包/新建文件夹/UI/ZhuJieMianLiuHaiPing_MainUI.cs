/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ZhuJieMianLiuHaiPing_MainUI : GComponent
    {
        public GComponent DMinMapUI;
        public GComponent DStateWindow;
        public GComponent DMonsterBlood;
        public GComponent TaskAndRanksPanel;
        public GComponent DFunBtms;
        public GComponent BottomUI;
        public GComponent DJoystick;
        public GComponent DArrackModelUI;
        public GComponent BottomPCUI;
        public GComponent DoubleDJoystick;
        public GButton BoxGiftBtn;
        public const string URL = "ui://jyvofh5ept7on1pn";

        public static ZhuJieMianLiuHaiPing_MainUI CreateInstance()
        {
            return (ZhuJieMianLiuHaiPing_MainUI)UIPackage.CreateObject("UI", "主界面刘海屏_MainUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DMinMapUI = (GComponent)GetChild("DMinMapUI");
            DStateWindow = (GComponent)GetChild("DStateWindow");
            DMonsterBlood = (GComponent)GetChild("DMonsterBlood");
            TaskAndRanksPanel = (GComponent)GetChild("TaskAndRanksPanel");
            DFunBtms = (GComponent)GetChild("DFunBtms");
            BottomUI = (GComponent)GetChild("BottomUI");
            DJoystick = (GComponent)GetChild("DJoystick");
            DArrackModelUI = (GComponent)GetChild("DArrackModelUI");
            BottomPCUI = (GComponent)GetChild("BottomPCUI");
            DoubleDJoystick = (GComponent)GetChild("DoubleDJoystick");
            BoxGiftBtn = (GButton)GetChild("BoxGiftBtn");
        }
    }
}