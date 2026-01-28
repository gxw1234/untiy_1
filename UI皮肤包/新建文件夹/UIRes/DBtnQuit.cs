/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnQuit : GButton
    {
        public Controller button;
        public GImage Img138808;
        public GImage Img139rl7;
        public const string URL = "ui://jk0io98jj3e21o6";

        public static DBtnQuit CreateInstance()
        {
            return (DBtnQuit)UIPackage.CreateObject("UIRes", "DBtnQuit");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img138808 = (GImage)GetChild("Img138808");
            Img139rl7 = (GImage)GetChild("Img139rl7");
        }
    }
}