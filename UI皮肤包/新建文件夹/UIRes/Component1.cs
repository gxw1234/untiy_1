/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Component1 : GComponent
    {
        public DBtnMiniMap DBtnMiniMap;
        public DBtnDeal DBtnDeal;
        public DBtnGuild DBtnGuild;
        public DBtnGroup DBtnGroup;
        public DBtnFriends DBtnFriends;
        public DBtnRankList DBtnRankList;
        public DBtnChatRec DBtnChatRec;
        public DBtnPlusAbil DBtnPlusAbil;
        public DBtnOut DBtnOut;
        public DBtnQuit DBtnQuit;
        public const string URL = "ui://jk0io98jj3e21oq";

        public static Component1 CreateInstance()
        {
            return (Component1)UIPackage.CreateObject("UIRes", "Component1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBtnMiniMap = (DBtnMiniMap)GetChild("DBtnMiniMap");
            DBtnDeal = (DBtnDeal)GetChild("DBtnDeal");
            DBtnGuild = (DBtnGuild)GetChild("DBtnGuild");
            DBtnGroup = (DBtnGroup)GetChild("DBtnGroup");
            DBtnFriends = (DBtnFriends)GetChild("DBtnFriends");
            DBtnRankList = (DBtnRankList)GetChild("DBtnRankList");
            DBtnChatRec = (DBtnChatRec)GetChild("DBtnChatRec");
            DBtnPlusAbil = (DBtnPlusAbil)GetChild("DBtnPlusAbil");
            DBtnOut = (DBtnOut)GetChild("DBtnOut");
            DBtnQuit = (DBtnQuit)GetChild("DBtnQuit");
        }
    }
}