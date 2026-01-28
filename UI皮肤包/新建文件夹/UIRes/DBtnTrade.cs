/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnTrade : GButton
    {
        public Controller button;
        public GImage Img265827;
        public GImage Img266o82;
        public GTextField ChatEdit43;
        public const string URL = "ui://jk0io98jkn5z15b";

        public static DBtnTrade CreateInstance()
        {
            return (DBtnTrade)UIPackage.CreateObject("UIRes", "DBtnTrade");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265827 = (GImage)GetChild("Img265827");
            Img266o82 = (GImage)GetChild("Img266o82");
            ChatEdit43 = (GTextField)GetChild("ChatEdit43");
        }
    }
}