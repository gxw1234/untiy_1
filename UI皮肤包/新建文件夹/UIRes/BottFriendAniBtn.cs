/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottFriendAniBtn : GButton
    {
        public Controller button;
        public GImage Img58177w;
        public GImage Img581v1v;
        public const string URL = "ui://jk0io98jv9b11s";

        public static BottFriendAniBtn CreateInstance()
        {
            return (BottFriendAniBtn)UIPackage.CreateObject("UIRes", "BottFriendAniBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img58177w = (GImage)GetChild("Img58177w");
            Img581v1v = (GImage)GetChild("Img581v1v");
        }
    }
}