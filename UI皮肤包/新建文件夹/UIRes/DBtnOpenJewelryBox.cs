/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnOpenJewelryBox : GButton
    {
        public Controller button;
        public GImage Img210eg3;
        public GImage Img211g74;
        public const string URL = "ui://jk0io98jj3e21hm";

        public static DBtnOpenJewelryBox CreateInstance()
        {
            return (DBtnOpenJewelryBox)UIPackage.CreateObject("UIRes", "DBtnOpenJewelryBox");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img210eg3 = (GImage)GetChild("Img210eg3");
            Img211g74 = (GImage)GetChild("Img211g74");
        }
    }
}