/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DMyFriendsTitle : GComponent
    {
        public GImage DMyFriendsTitle;
        public GTextField DMyFriendName;
        public GTextField DMyFriendGuild;
        public GTextField DMyFriendLevel;
        public GTextField DMyFriendJob;
        public GTextField DMyFriendState;
        public const string URL = "ui://jk0io98jkn5z14z";

        public static DMyFriendsTitle CreateInstance()
        {
            return (DMyFriendsTitle)UIPackage.CreateObject("UIRes", "DMyFriendsTitle");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DMyFriendsTitle = (GImage)GetChild("DMyFriendsTitle");
            DMyFriendName = (GTextField)GetChild("DMyFriendName");
            DMyFriendGuild = (GTextField)GetChild("DMyFriendGuild");
            DMyFriendLevel = (GTextField)GetChild("DMyFriendLevel");
            DMyFriendJob = (GTextField)GetChild("DMyFriendJob");
            DMyFriendState = (GTextField)GetChild("DMyFriendState");
        }
    }
}