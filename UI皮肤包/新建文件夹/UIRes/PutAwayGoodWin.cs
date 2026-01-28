/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class PutAwayGoodWin : GComponent
    {
        public GImage PutAwayGoodWin;
        public GLoader Eff21;
        public GLoader Eff11;
        public GLoader icon;
        public GTextField title;
        public GLoader Eff22;
        public GLoader Eff12;
        public GLoader Eff23;
        public GLoader Eff13;
        public GLoader bagsLod;
        public GTextField StarLevel;
        public const string URL = "ui://jk0io98jkn5z12i";

        public static PutAwayGoodWin CreateInstance()
        {
            return (PutAwayGoodWin)UIPackage.CreateObject("UIRes", "PutAwayGoodWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            PutAwayGoodWin = (GImage)GetChild("PutAwayGoodWin");
            Eff21 = (GLoader)GetChild("Eff21");
            Eff11 = (GLoader)GetChild("Eff11");
            icon = (GLoader)GetChild("icon");
            title = (GTextField)GetChild("title");
            Eff22 = (GLoader)GetChild("Eff22");
            Eff12 = (GLoader)GetChild("Eff12");
            Eff23 = (GLoader)GetChild("Eff23");
            Eff13 = (GLoader)GetChild("Eff13");
            bagsLod = (GLoader)GetChild("bagsLod");
            StarLevel = (GTextField)GetChild("StarLevel");
        }
    }
}