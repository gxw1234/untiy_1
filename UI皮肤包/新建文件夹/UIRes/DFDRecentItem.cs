/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DFDRecentItem : GButton
    {
        public Controller button;
        public GImage Img2730c3;
        public GImage Img3033u5;
        public DBtnfdragree DBtnfdragree;
        public DBtnfdrrefuse DBtnfdrrefuse;
        public GTextField Dfdrguild;
        public GTextField Dfdrlevel;
        public GTextField Dfdrname;
        public const string URL = "ui://jk0io98jkn5z15r";

        public static DFDRecentItem CreateInstance()
        {
            return (DFDRecentItem)UIPackage.CreateObject("UIRes", "DFDRecentItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2730c3 = (GImage)GetChild("Img2730c3");
            Img3033u5 = (GImage)GetChild("Img3033u5");
            DBtnfdragree = (DBtnfdragree)GetChild("DBtnfdragree");
            DBtnfdrrefuse = (DBtnfdrrefuse)GetChild("DBtnfdrrefuse");
            Dfdrguild = (GTextField)GetChild("Dfdrguild");
            Dfdrlevel = (GTextField)GetChild("Dfdrlevel");
            Dfdrname = (GTextField)GetChild("Dfdrname");
        }
    }
}