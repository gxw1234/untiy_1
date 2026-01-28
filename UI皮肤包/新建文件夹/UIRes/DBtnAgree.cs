/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAgree : GButton
    {
        public Controller button;
        public GImage Img286003;
        public GImage Img287ij3;
        public GTextField ChatEdit51;
        public const string URL = "ui://jk0io98jkn5zud";

        public static DBtnAgree CreateInstance()
        {
            return (DBtnAgree)UIPackage.CreateObject("UIRes", "DBtnAgree");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img286003 = (GImage)GetChild("Img286003");
            Img287ij3 = (GImage)GetChild("Img287ij3");
            ChatEdit51 = (GTextField)GetChild("ChatEdit51");
        }
    }
}