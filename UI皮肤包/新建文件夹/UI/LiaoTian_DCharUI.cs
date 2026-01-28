/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class LiaoTian_DCharUI : GComponent
    {
        public Controller CRadios;
        public GImage DCharUI;
        public GButton DBtnSend;
        public GButton DBtn;
        public GButton DRBIntegrated;
        public GButton DRBSystem;
        public GButton DRBWorld;
        public GButton DRBWhisper;
        public GButton DRBGuild;
        public GButton DRBGroup;
        public GButton DRBHear;
        public GList DChatWindow;
        public GTextInput DEditChar;
        public GButton DBtnEmoticon;
        public GButton DBtnBag;
        public GButton DBtnPosition;
        public GComponent DChatToptem;
        public GButton DBtnAutoSendClose;
        public GButton DBtnAutoSendOpen;
        public const string URL = "ui://jyvofh5ej3e21ku";

        public static LiaoTian_DCharUI CreateInstance()
        {
            return (LiaoTian_DCharUI)UIPackage.CreateObject("UI", "聊天_DCharUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CRadios = GetController("CRadios");
            DCharUI = (GImage)GetChild("DCharUI");
            DBtnSend = (GButton)GetChild("DBtnSend");
            DBtn = (GButton)GetChild("DBtn");
            DRBIntegrated = (GButton)GetChild("DRBIntegrated");
            DRBSystem = (GButton)GetChild("DRBSystem");
            DRBWorld = (GButton)GetChild("DRBWorld");
            DRBWhisper = (GButton)GetChild("DRBWhisper");
            DRBGuild = (GButton)GetChild("DRBGuild");
            DRBGroup = (GButton)GetChild("DRBGroup");
            DRBHear = (GButton)GetChild("DRBHear");
            DChatWindow = (GList)GetChild("DChatWindow");
            DEditChar = (GTextInput)GetChild("DEditChar");
            DBtnEmoticon = (GButton)GetChild("DBtnEmoticon");
            DBtnBag = (GButton)GetChild("DBtnBag");
            DBtnPosition = (GButton)GetChild("DBtnPosition");
            DChatToptem = (GComponent)GetChild("DChatToptem");
            DBtnAutoSendClose = (GButton)GetChild("DBtnAutoSendClose");
            DBtnAutoSendOpen = (GButton)GetChild("DBtnAutoSendOpen");
        }
    }
}