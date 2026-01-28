/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottGuildWin : GComponent
    {
        public BottGuildAniBtn BottGuildAniBtn;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b11p";

        public static BottGuildWin CreateInstance()
        {
            return (BottGuildWin)UIPackage.CreateObject("UIRes", "BottGuildWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            BottGuildAniBtn = (BottGuildAniBtn)GetChild("BottGuildAniBtn");
            select = GetTransition("select");
        }
    }
}