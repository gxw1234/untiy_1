/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page1Item : GButton
    {
        public Controller button;
        public GImage Img27378w;
        public GImage Img3035ni;
        public DBtnRefuse DBtnRefuse;
        public DBtnAgree DBtnAgree;
        public GTextField Dfdname;
        public GTextField Dfdlevel;
        public GTextField Dfdguild;
        public const string URL = "ui://jk0io98jkn5zul";

        public static Page1Item CreateInstance()
        {
            return (Page1Item)UIPackage.CreateObject("UIRes", "Page1Item");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img27378w = (GImage)GetChild("Img27378w");
            Img3035ni = (GImage)GetChild("Img3035ni");
            DBtnRefuse = (DBtnRefuse)GetChild("DBtnRefuse");
            DBtnAgree = (DBtnAgree)GetChild("DBtnAgree");
            Dfdname = (GTextField)GetChild("Dfdname");
            Dfdlevel = (GTextField)GetChild("Dfdlevel");
            Dfdguild = (GTextField)GetChild("Dfdguild");
        }
    }
}