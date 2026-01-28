/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAuctionGuild : GButton
    {
        public Controller button;
        public GImage Img6278k1;
        public GImage Img6280rq;
        public const string URL = "ui://jk0io98jk02tn1ul";

        public static DBtnAuctionGuild CreateInstance()
        {
            return (DBtnAuctionGuild)UIPackage.CreateObject("UIRes", "DBtnAuctionGuild");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img6278k1 = (GImage)GetChild("Img6278k1");
            Img6280rq = (GImage)GetChild("Img6280rq");
        }
    }
}