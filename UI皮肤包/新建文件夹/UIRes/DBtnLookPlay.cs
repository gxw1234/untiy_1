/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnLookPlay : GButton
    {
        public Controller button;
        public GImage Img265t0m;
        public GImage Img266t8h;
        public GTextField ChatEdit39;
        public const string URL = "ui://jk0io98jkn5z157";

        public static DBtnLookPlay CreateInstance()
        {
            return (DBtnLookPlay)UIPackage.CreateObject("UIRes", "DBtnLookPlay");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265t0m = (GImage)GetChild("Img265t0m");
            Img266t8h = (GImage)GetChild("Img266t8h");
            ChatEdit39 = (GTextField)GetChild("ChatEdit39");
        }
    }
}