/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ZhuJieMian_MainUI : GComponent
    {
        public GComponent DBtnsWID;
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
        public Transition t0;
        public const string URL = "ui://jyvofh5etd9g0";

        public static ZhuJieMian_MainUI CreateInstance()
        {
            return (ZhuJieMian_MainUI)UIPackage.CreateObject("UI", "主界面_MainUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBtnsWID = (GComponent)GetChild("DBtnsWID");
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
            t0 = GetTransition("t0");
        }
    }
}