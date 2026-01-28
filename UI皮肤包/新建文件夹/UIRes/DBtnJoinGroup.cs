/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnJoinGroup : GButton
    {
        public Controller button;
        public GImage Img26575p;
        public GImage Img266c5p;
        public GTextField ChatEdit41;
        public const string URL = "ui://jk0io98jkn5z159";

        public static DBtnJoinGroup CreateInstance()
        {
            return (DBtnJoinGroup)UIPackage.CreateObject("UIRes", "DBtnJoinGroup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img26575p = (GImage)GetChild("Img26575p");
            Img266c5p = (GImage)GetChild("Img266c5p");
            ChatEdit41 = (GTextField)GetChild("ChatEdit41");
        }
    }
}