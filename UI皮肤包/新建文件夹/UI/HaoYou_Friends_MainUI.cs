/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class HaoYou_Friends_MainUI : GComponent
    {
        public Controller CPages;
        public GImage FriendsUI;
        public GComponent frame;
        public GButton DBtnFriendApplication;
        public GButton DBtnMyFriend;
        public GButton DBtnRecentContact;
        public GButton DBtnBlacklist;
        public GButton DBtnFriendsUIClose;
        public GComponent DA2EWindow1;
        public GImage DA2EIMAGE1;
        public GGraph ModalLayer;
        public GComponent DA2EPage1;
        public GComponent DA2EPage2;
        public GComponent DA2EPage3;
        public GComponent DA2EPage4;
        public const string URL = "ui://jyvofh5ekn5z15v";

        public static HaoYou_Friends_MainUI CreateInstance()
        {
            return (HaoYou_Friends_MainUI)UIPackage.CreateObject("UI", "好友_Friends_MainUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CPages = GetController("CPages");
            FriendsUI = (GImage)GetChild("FriendsUI");
            frame = (GComponent)GetChild("frame");
            DBtnFriendApplication = (GButton)GetChild("DBtnFriendApplication");
            DBtnMyFriend = (GButton)GetChild("DBtnMyFriend");
            DBtnRecentContact = (GButton)GetChild("DBtnRecentContact");
            DBtnBlacklist = (GButton)GetChild("DBtnBlacklist");
            DBtnFriendsUIClose = (GButton)GetChild("DBtnFriendsUIClose");
            DA2EWindow1 = (GComponent)GetChild("DA2EWindow1");
            DA2EIMAGE1 = (GImage)GetChild("DA2EIMAGE1");
            ModalLayer = (GGraph)GetChild("ModalLayer");
            DA2EPage1 = (GComponent)GetChild("DA2EPage1");
            DA2EPage2 = (GComponent)GetChild("DA2EPage2");
            DA2EPage3 = (GComponent)GetChild("DA2EPage3");
            DA2EPage4 = (GComponent)GetChild("DA2EPage4");
        }
    }
}