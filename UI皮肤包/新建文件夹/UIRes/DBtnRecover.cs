/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnRecover : GButton
    {
        public Controller button;
        public GImage Img22r02;
        public GImage Img232m5;
        public const string URL = "ui://jk0io98jq33o8";

        public static DBtnRecover CreateInstance()
        {
            return (DBtnRecover)UIPackage.CreateObject("UIRes", "DBtnRecover");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img22r02 = (GImage)GetChild("Img22r02");
            Img232m5 = (GImage)GetChild("Img232m5");
        }
    }
}