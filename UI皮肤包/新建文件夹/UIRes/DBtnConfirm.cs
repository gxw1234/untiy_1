/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnConfirm : GButton
    {
        public Controller button;
        public GImage Img1957wd;
        public GImage Img196vc3;
        public const string URL = "ui://jk0io98jj3e21l4";

        public static DBtnConfirm CreateInstance()
        {
            return (DBtnConfirm)UIPackage.CreateObject("UIRes", "DBtnConfirm");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1957wd = (GImage)GetChild("Img1957wd");
            Img196vc3 = (GImage)GetChild("Img196vc3");
        }
    }
}