/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class HaoYou_DFunPanel : GComponent
    {
        public GImage DFunPanel;
        public GTextField DPlayName;
        public GButton DBtnLookPlay;
        public GButton DBtnChat;
        public GButton DBtnJoinGroup;
        public GButton DBtnAddFriend;
        public GButton DBtnTrade;
        public GButton DBtnBlock;
        public GButton DBtnFristSet;
        public const string URL = "ui://jyvofh5ekn5z15t";

        public static HaoYou_DFunPanel CreateInstance()
        {
            return (HaoYou_DFunPanel)UIPackage.CreateObject("UI", "好友_DFunPanel");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DFunPanel = (GImage)GetChild("DFunPanel");
            DPlayName = (GTextField)GetChild("DPlayName");
            DBtnLookPlay = (GButton)GetChild("DBtnLookPlay");
            DBtnChat = (GButton)GetChild("DBtnChat");
            DBtnJoinGroup = (GButton)GetChild("DBtnJoinGroup");
            DBtnAddFriend = (GButton)GetChild("DBtnAddFriend");
            DBtnTrade = (GButton)GetChild("DBtnTrade");
            DBtnBlock = (GButton)GetChild("DBtnBlock");
            DBtnFristSet = (GButton)GetChild("DBtnFristSet");
        }
    }
}