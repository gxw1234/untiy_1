/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DiplomacyItem : GButton
    {
        public Controller button;
        public GImage Img254o67;
        public GImage Img30124p;
        public GTextField GuildName;
        public GTextField HomeName;
        public GTextField Player;
        public GTextField EditCountDown;
        public GLoader LoaderTag;
        public BtnDeclareWar BtnDeclareWar;
        public BtnInviteGroup BtnInviteGroup;
        public BtnLeague BtnLeague;
        public BtnCancelWar BtnCancelWar;
        public const string URL = "ui://jk0io98jkn5z18d";

        public static DiplomacyItem CreateInstance()
        {
            return (DiplomacyItem)UIPackage.CreateObject("UIRes", "DiplomacyItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img254o67 = (GImage)GetChild("Img254o67");
            Img30124p = (GImage)GetChild("Img30124p");
            GuildName = (GTextField)GetChild("GuildName");
            HomeName = (GTextField)GetChild("HomeName");
            Player = (GTextField)GetChild("Player");
            EditCountDown = (GTextField)GetChild("EditCountDown");
            LoaderTag = (GLoader)GetChild("LoaderTag");
            BtnDeclareWar = (BtnDeclareWar)GetChild("BtnDeclareWar");
            BtnInviteGroup = (BtnInviteGroup)GetChild("BtnInviteGroup");
            BtnLeague = (BtnLeague)GetChild("BtnLeague");
            BtnCancelWar = (BtnCancelWar)GetChild("BtnCancelWar");
        }
    }
}