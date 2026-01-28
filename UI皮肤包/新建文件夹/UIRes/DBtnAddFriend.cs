/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAddFriend : GButton
    {
        public Controller button;
        public GImage Img2657wv;
        public GImage Img266u2s;
        public GTextField ChatEdit42;
        public const string URL = "ui://jk0io98jkn5z15a";

        public static DBtnAddFriend CreateInstance()
        {
            return (DBtnAddFriend)UIPackage.CreateObject("UIRes", "DBtnAddFriend");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2657wv = (GImage)GetChild("Img2657wv");
            Img266u2s = (GImage)GetChild("Img266u2s");
            ChatEdit42 = (GTextField)GetChild("ChatEdit42");
        }
    }
}