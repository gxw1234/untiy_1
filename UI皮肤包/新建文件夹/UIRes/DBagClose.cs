/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBagClose : GButton
    {
        public Controller button;
        public GImage Img0ytp;
        public GImage Img1h37;
        public const string URL = "ui://jk0io98jv9b14w";

        public static DBagClose CreateInstance()
        {
            return (DBagClose)UIPackage.CreateObject("UIRes", "DBagClose");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img0ytp = (GImage)GetChild("Img0ytp");
            Img1h37 = (GImage)GetChild("Img1h37");
        }
    }
}