/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class MemberItem : GButton
    {
        public Controller button;
        public GImage Img254rpp;
        public GImage Img301c4v;
        public GTextField EditPlayName;
        public GTextField EditPlayLevel;
        public GTextField EditPlayPrf;
        public GTextField EditPlayPos;
        public GTextField EditPlayState;
        public GLoader LoaderMemberTag;
        public const string URL = "ui://jk0io98jkn5z18g";

        public static MemberItem CreateInstance()
        {
            return (MemberItem)UIPackage.CreateObject("UIRes", "MemberItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img254rpp = (GImage)GetChild("Img254rpp");
            Img301c4v = (GImage)GetChild("Img301c4v");
            EditPlayName = (GTextField)GetChild("EditPlayName");
            EditPlayLevel = (GTextField)GetChild("EditPlayLevel");
            EditPlayPrf = (GTextField)GetChild("EditPlayPrf");
            EditPlayPos = (GTextField)GetChild("EditPlayPos");
            EditPlayState = (GTextField)GetChild("EditPlayState");
            LoaderMemberTag = (GLoader)GetChild("LoaderMemberTag");
        }
    }
}