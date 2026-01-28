/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnMiniMap : GButton
    {
        public Controller button;
        public GImage Img1300dw;
        public GImage Img1313xs;
        public const string URL = "ui://jk0io98jj3e21ny";

        public static DBtnMiniMap CreateInstance()
        {
            return (DBtnMiniMap)UIPackage.CreateObject("UIRes", "DBtnMiniMap");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1300dw = (GImage)GetChild("Img1300dw");
            Img1313xs = (GImage)GetChild("Img1313xs");
        }
    }
}