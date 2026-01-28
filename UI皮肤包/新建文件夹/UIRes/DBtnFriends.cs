/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnFriends : GButton
    {
        public Controller button;
        public GImage Img773cv;
        public GImage Img78pp4;
        public const string URL = "ui://jk0io98jk02tn1uh";

        public static DBtnFriends CreateInstance()
        {
            return (DBtnFriends)UIPackage.CreateObject("UIRes", "DBtnFriends");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img773cv = (GImage)GetChild("Img773cv");
            Img78pp4 = (GImage)GetChild("Img78pp4");
        }
    }
}