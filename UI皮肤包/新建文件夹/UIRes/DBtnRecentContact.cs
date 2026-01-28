/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnRecentContact : GButton
    {
        public Controller button;
        public GImage Img279dg8;
        public GImage Img278403;
        public const string URL = "ui://jk0io98jkn5z15g";

        public static DBtnRecentContact CreateInstance()
        {
            return (DBtnRecentContact)UIPackage.CreateObject("UIRes", "DBtnRecentContact");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img279dg8 = (GImage)GetChild("Img279dg8");
            Img278403 = (GImage)GetChild("Img278403");
        }
    }
}