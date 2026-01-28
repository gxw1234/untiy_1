/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnStalling : GButton
    {
        public Controller button;
        public GImage Img73j7w;
        public GImage Img74oab;
        public const string URL = "ui://jk0io98jk02tn1uj";

        public static DBtnStalling CreateInstance()
        {
            return (DBtnStalling)UIPackage.CreateObject("UIRes", "DBtnStalling");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img73j7w = (GImage)GetChild("Img73j7w");
            Img74oab = (GImage)GetChild("Img74oab");
        }
    }
}