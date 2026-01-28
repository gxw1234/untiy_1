/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnOut : GButton
    {
        public Controller button;
        public GImage Img1367a7;
        public GImage Img137y2h;
        public const string URL = "ui://jk0io98jj3e21o5";

        public static DBtnOut CreateInstance()
        {
            return (DBtnOut)UIPackage.CreateObject("UIRes", "DBtnOut");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1367a7 = (GImage)GetChild("Img1367a7");
            Img137y2h = (GImage)GetChild("Img137y2h");
        }
    }
}