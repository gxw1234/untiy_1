/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottFriendWin : GComponent
    {
        public BottFriendAniBtn BottFriendAniBtn;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b11r";

        public static BottFriendWin CreateInstance()
        {
            return (BottFriendWin)UIPackage.CreateObject("UIRes", "BottFriendWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            BottFriendAniBtn = (BottFriendAniBtn)GetChild("BottFriendAniBtn");
            select = GetTransition("select");
        }
    }
}