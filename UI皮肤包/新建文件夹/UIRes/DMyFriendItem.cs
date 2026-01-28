/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DMyFriendItem : GButton
    {
        public Controller button;
        public GImage Img273f6y;
        public GImage Img30335t;
        public GTextField ChatEdit6;
        public GTextField Dmflevel;
        public GTextField Dmfjob;
        public GTextField Dmfguild;
        public GTextField Dmystate;
        public const string URL = "ui://jk0io98jkn5z15u";

        public static DMyFriendItem CreateInstance()
        {
            return (DMyFriendItem)UIPackage.CreateObject("UIRes", "DMyFriendItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img273f6y = (GImage)GetChild("Img273f6y");
            Img30335t = (GImage)GetChild("Img30335t");
            ChatEdit6 = (GTextField)GetChild("ChatEdit6");
            Dmflevel = (GTextField)GetChild("Dmflevel");
            Dmfjob = (GTextField)GetChild("Dmfjob");
            Dmfguild = (GTextField)GetChild("Dmfguild");
            Dmystate = (GTextField)GetChild("Dmystate");
        }
    }
}