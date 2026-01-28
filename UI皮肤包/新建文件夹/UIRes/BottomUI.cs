/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottomUI : GComponent
    {
        public GImage bg;
        public DMPBall DMPBall;
        public DHPBall DHPBall;
        public GImage DHPBall1;
        public GImage DMPBall1;
        public MpWin1 MpWin1;
        public HpWin1 HpWin1;
        public GImage DA2EIMAGE2;
        public GImage DA2EIMAGE1;
        public GTextField timerHour;
        public GList DChatWindow;
        public GList bagItemCell;
        public GLoader DModel;
        public GLoader wifi;
        public battery battery;
        public DLevel DLevel;
        public DWetBar DWetBar;
        public DExpBar DExpBar;
        public GImage DExpIcon;
        public AutoFight AutoFight;
        public AutoWay AutoWay;
        public BtnNpc BtnNpc;
        public GImage DWetIcon;
        public BottMailWin BottMailWin;
        public BottGroupWin BottGroupWin;
        public GTextField timerMinute;
        public GTextField timeSecond;
        public GTextField TimeIinterval1;
        public GTextField TimeIinterval2;
        public BottGuildWin BottGuildWin;
        public BottFriendWin BottFriendWin;
        public BottomRankBtn BottomRankBtn;
        public DiyComNode DiyComNode;
        public Buttom_volume buttonVolume;
        public GTextField textVolume;
        public GLoader DRun;
        public const string URL = "ui://jk0io98jv9b119";

        public static BottomUI CreateInstance()
        {
            return (BottomUI)UIPackage.CreateObject("UIRes", "BottomUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            DMPBall = (DMPBall)GetChild("DMPBall");
            DHPBall = (DHPBall)GetChild("DHPBall");
            DHPBall1 = (GImage)GetChild("DHPBall1");
            DMPBall1 = (GImage)GetChild("DMPBall1");
            MpWin1 = (MpWin1)GetChild("MpWin1");
            HpWin1 = (HpWin1)GetChild("HpWin1");
            DA2EIMAGE2 = (GImage)GetChild("DA2EIMAGE2");
            DA2EIMAGE1 = (GImage)GetChild("DA2EIMAGE1");
            timerHour = (GTextField)GetChild("timerHour");
            DChatWindow = (GList)GetChild("DChatWindow");
            bagItemCell = (GList)GetChild("bagItemCell");
            DModel = (GLoader)GetChild("DModel");
            wifi = (GLoader)GetChild("wifi");
            battery = (battery)GetChild("battery");
            DLevel = (DLevel)GetChild("DLevel");
            DWetBar = (DWetBar)GetChild("DWetBar");
            DExpBar = (DExpBar)GetChild("DExpBar");
            DExpIcon = (GImage)GetChild("DExpIcon");
            AutoFight = (AutoFight)GetChild("AutoFight");
            AutoWay = (AutoWay)GetChild("AutoWay");
            BtnNpc = (BtnNpc)GetChild("BtnNpc");
            DWetIcon = (GImage)GetChild("DWetIcon");
            BottMailWin = (BottMailWin)GetChild("BottMailWin");
            BottGroupWin = (BottGroupWin)GetChild("BottGroupWin");
            timerMinute = (GTextField)GetChild("timerMinute");
            timeSecond = (GTextField)GetChild("timeSecond");
            TimeIinterval1 = (GTextField)GetChild("TimeIinterval1");
            TimeIinterval2 = (GTextField)GetChild("TimeIinterval2");
            BottGuildWin = (BottGuildWin)GetChild("BottGuildWin");
            BottFriendWin = (BottFriendWin)GetChild("BottFriendWin");
            BottomRankBtn = (BottomRankBtn)GetChild("BottomRankBtn");
            DiyComNode = (DiyComNode)GetChild("DiyComNode");
            buttonVolume = (Buttom_volume)GetChild("buttonVolume");
            textVolume = (GTextField)GetChild("textVolume");
            DRun = (GLoader)GetChild("DRun");
        }
    }
}