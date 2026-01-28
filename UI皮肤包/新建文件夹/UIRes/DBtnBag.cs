/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnBag : GButton
    {
        public Controller button;
        public GImage Img71ge8;
        public GImage Img72e30;
        public const string URL = "ui://jk0io98jk02tn1uq";

        public static DBtnBag CreateInstance()
        {
            return (DBtnBag)UIPackage.CreateObject("UIRes", "DBtnBag");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img71ge8 = (GImage)GetChild("Img71ge8");
            Img72e30 = (GImage)GetChild("Img72e30");
        }
    }
}