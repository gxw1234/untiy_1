/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnFriendApplication : GButton
    {
        public Controller button;
        public GImage Img272g8g;
        public GImage Img2715cb;
        public const string URL = "ui://jk0io98jkn5z15e";

        public static DBtnFriendApplication CreateInstance()
        {
            return (DBtnFriendApplication)UIPackage.CreateObject("UIRes", "DBtnFriendApplication");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img272g8g = (GImage)GetChild("Img272g8g");
            Img2715cb = (GImage)GetChild("Img2715cb");
        }
    }
}