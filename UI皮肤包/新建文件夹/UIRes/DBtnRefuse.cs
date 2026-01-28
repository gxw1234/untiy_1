/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnRefuse : GButton
    {
        public Controller button;
        public GImage Img28668e;
        public GImage Img287u35;
        public GTextField ChatEdit7;
        public const string URL = "ui://jk0io98jkn5zuc";

        public static DBtnRefuse CreateInstance()
        {
            return (DBtnRefuse)UIPackage.CreateObject("UIRes", "DBtnRefuse");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img28668e = (GImage)GetChild("Img28668e");
            Img287u35 = (GImage)GetChild("Img287u35");
            ChatEdit7 = (GTextField)GetChild("ChatEdit7");
        }
    }
}