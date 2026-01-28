/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnChangeJob : GButton
    {
        public Controller button;
        public GImage Img1738tvn;
        public GImage Img17393g6;
        public const string URL = "ui://jk0io98jj3e21nr";

        public static DBtnChangeJob CreateInstance()
        {
            return (DBtnChangeJob)UIPackage.CreateObject("UIRes", "DBtnChangeJob");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1738tvn = (GImage)GetChild("Img1738tvn");
            Img17393g6 = (GImage)GetChild("Img17393g6");
        }
    }
}