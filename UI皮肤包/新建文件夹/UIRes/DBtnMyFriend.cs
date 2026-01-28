/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnMyFriend : GButton
    {
        public Controller button;
        public GImage Img277io8;
        public GImage Img276150;
        public const string URL = "ui://jk0io98jkn5z15f";

        public static DBtnMyFriend CreateInstance()
        {
            return (DBtnMyFriend)UIPackage.CreateObject("UIRes", "DBtnMyFriend");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img277io8 = (GImage)GetChild("Img277io8");
            Img276150 = (GImage)GetChild("Img276150");
        }
    }
}