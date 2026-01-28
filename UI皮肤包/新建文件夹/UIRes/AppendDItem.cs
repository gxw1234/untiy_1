/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class AppendDItem : GButton
    {
        public Controller button;
        public GImage Img789h8a;
        public GImage Img7897wn;
        public GLoader Eff21;
        public GLoader Eff11;
        public GLoader icon;
        public GTextField ChatEdit58;
        public GLoader Eff22;
        public GLoader Eff12;
        public GLoader Eff23;
        public GLoader Eff13;
        public GLoader bagsLod;
        public GLoader bagsLods;
        public const string URL = "ui://jk0io98jkn5zyr";

        public static AppendDItem CreateInstance()
        {
            return (AppendDItem)UIPackage.CreateObject("UIRes", "AppendDItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img789h8a = (GImage)GetChild("Img789h8a");
            Img7897wn = (GImage)GetChild("Img7897wn");
            Eff21 = (GLoader)GetChild("Eff21");
            Eff11 = (GLoader)GetChild("Eff11");
            icon = (GLoader)GetChild("icon");
            ChatEdit58 = (GTextField)GetChild("ChatEdit58");
            Eff22 = (GLoader)GetChild("Eff22");
            Eff12 = (GLoader)GetChild("Eff12");
            Eff23 = (GLoader)GetChild("Eff23");
            Eff13 = (GLoader)GetChild("Eff13");
            bagsLod = (GLoader)GetChild("bagsLod");
            bagsLods = (GLoader)GetChild("bagsLods");
        }
    }
}