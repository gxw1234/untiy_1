/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TabBtnGuild : GButton
    {
        public Controller button;
        public GImage Img251m05;
        public GImage Img250x15;
        public const string URL = "ui://jk0io98jkn5z17b";

        public static TabBtnGuild CreateInstance()
        {
            return (TabBtnGuild)UIPackage.CreateObject("UIRes", "TabBtnGuild");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img251m05 = (GImage)GetChild("Img251m05");
            Img250x15 = (GImage)GetChild("Img250x15");
        }
    }
}