/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ApplyItem : GButton
    {
        public Controller button;
        public GImage Img254v55;
        public GImage Img301i2r;
        public GTextField GuildName;
        public GTextField HomeName;
        public GTextField Player;
        public GTextField Condition;
        public GTextField EditText;
        public BtnOneKeyApplys BtnOneKeyApplys;
        public BtnRepealApply BtnRepealApply;
        public const string URL = "ui://jk0io98jkn5z189";

        public static ApplyItem CreateInstance()
        {
            return (ApplyItem)UIPackage.CreateObject("UIRes", "ApplyItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img254v55 = (GImage)GetChild("Img254v55");
            Img301i2r = (GImage)GetChild("Img301i2r");
            GuildName = (GTextField)GetChild("GuildName");
            HomeName = (GTextField)GetChild("HomeName");
            Player = (GTextField)GetChild("Player");
            Condition = (GTextField)GetChild("Condition");
            EditText = (GTextField)GetChild("EditText");
            BtnOneKeyApplys = (BtnOneKeyApplys)GetChild("BtnOneKeyApplys");
            BtnRepealApply = (BtnRepealApply)GetChild("BtnRepealApply");
        }
    }
}