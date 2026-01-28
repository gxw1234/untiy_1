/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnDeal : GButton
    {
        public Controller button;
        public GImage Img13218d;
        public GImage Img1337i2;
        public const string URL = "ui://jk0io98jj3e21nz";

        public static DBtnDeal CreateInstance()
        {
            return (DBtnDeal)UIPackage.CreateObject("UIRes", "DBtnDeal");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img13218d = (GImage)GetChild("Img13218d");
            Img1337i2 = (GImage)GetChild("Img1337i2");
        }
    }
}