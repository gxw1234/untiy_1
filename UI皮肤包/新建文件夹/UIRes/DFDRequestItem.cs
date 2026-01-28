/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DFDRequestItem : GButton
    {
        public Controller button;
        public GImage Img2731q0;
        public GImage Img303g5u;
        public GTextField Dfdname;
        public GTextField Dfdlevel;
        public GTextField Dfdguild;
        public DBtnRefuse DBtnRefuse;
        public DBtnAgree DBtnAgree;
        public const string URL = "ui://jk0io98jkn5z15s";

        public static DFDRequestItem CreateInstance()
        {
            return (DFDRequestItem)UIPackage.CreateObject("UIRes", "DFDRequestItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2731q0 = (GImage)GetChild("Img2731q0");
            Img303g5u = (GImage)GetChild("Img303g5u");
            Dfdname = (GTextField)GetChild("Dfdname");
            Dfdlevel = (GTextField)GetChild("Dfdlevel");
            Dfdguild = (GTextField)GetChild("Dfdguild");
            DBtnRefuse = (DBtnRefuse)GetChild("DBtnRefuse");
            DBtnAgree = (DBtnAgree)GetChild("DBtnAgree");
        }
    }
}