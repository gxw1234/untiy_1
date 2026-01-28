/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnFriendsUIClose : GButton
    {
        public Controller button;
        public GImage Img000x;
        public GImage Img1447;
        public const string URL = "ui://jk0io98jkn5z15i";

        public static DBtnFriendsUIClose CreateInstance()
        {
            return (DBtnFriendsUIClose)UIPackage.CreateObject("UIRes", "DBtnFriendsUIClose");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img000x = (GImage)GetChild("Img000x");
            Img1447 = (GImage)GetChild("Img1447");
        }
    }
}