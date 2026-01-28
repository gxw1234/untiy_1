/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DMidleComp : GComponent
    {
        public DBtnChatRec DBtnChatRec;
        public DBtnDeal DBtnDeal;
        public DBtnFriends DBtnFriends;
        public DBtnGroup DBtnGroup;
        public DBtnGuild DBtnGuild;
        public DBtnMiniMap DBtnMiniMap;
        public DBtnOut DBtnOut;
        public DBtnPlusAbil DBtnPlusAbil;
        public DBtnQuit DBtnQuit;
        public DBtnRankList DBtnRankList;
        public const string URL = "ui://jk0io98jldxan2q2";

        public static DMidleComp CreateInstance()
        {
            return (DMidleComp)UIPackage.CreateObject("UIRes", "DMidleComp");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBtnChatRec = (DBtnChatRec)GetChild("DBtnChatRec");
            DBtnDeal = (DBtnDeal)GetChild("DBtnDeal");
            DBtnFriends = (DBtnFriends)GetChild("DBtnFriends");
            DBtnGroup = (DBtnGroup)GetChild("DBtnGroup");
            DBtnGuild = (DBtnGuild)GetChild("DBtnGuild");
            DBtnMiniMap = (DBtnMiniMap)GetChild("DBtnMiniMap");
            DBtnOut = (DBtnOut)GetChild("DBtnOut");
            DBtnPlusAbil = (DBtnPlusAbil)GetChild("DBtnPlusAbil");
            DBtnQuit = (DBtnQuit)GetChild("DBtnQuit");
            DBtnRankList = (DBtnRankList)GetChild("DBtnRankList");
        }
    }
}