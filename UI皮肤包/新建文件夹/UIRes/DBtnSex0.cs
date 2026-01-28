/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnSex0 : GButton
    {
        public Controller button;
        public GImage Img286k5;
        public GImage Img298v7;
        public const string URL = "ui://jk0io98j4w02a";

        public static DBtnSex0 CreateInstance()
        {
            return (DBtnSex0)UIPackage.CreateObject("UIRes", "DBtnSex0");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img286k5 = (GImage)GetChild("Img286k5");
            Img298v7 = (GImage)GetChild("Img298v7");
        }
    }
}