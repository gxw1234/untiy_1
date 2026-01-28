/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnStateColse : GButton
    {
        public Controller button;
        public GImage Img0toy;
        public GImage Img1o40;
        public const string URL = "ui://jk0io98jkn5zxs";

        public static DBtnStateColse CreateInstance()
        {
            return (DBtnStateColse)UIPackage.CreateObject("UIRes", "DBtnStateColse");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img0toy = (GImage)GetChild("Img0toy");
            Img1o40 = (GImage)GetChild("Img1o40");
        }
    }
}