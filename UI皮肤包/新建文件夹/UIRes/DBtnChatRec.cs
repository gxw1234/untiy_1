/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnChatRec : GButton
    {
        public Controller button;
        public GImage Img1151167;
        public GImage Img1152h10;
        public const string URL = "ui://jk0io98jj3e21o4";

        public static DBtnChatRec CreateInstance()
        {
            return (DBtnChatRec)UIPackage.CreateObject("UIRes", "DBtnChatRec");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1151167 = (GImage)GetChild("Img1151167");
            Img1152h10 = (GImage)GetChild("Img1152h10");
        }
    }
}