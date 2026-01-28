/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class GridItem : GButton
    {
        public Controller button;
        public GLoader bg;
        public GLoader Eff21;
        public GLoader Eff11;
        public GLoader item;
        public GTextField title;
        public GLoader Eff22;
        public GLoader Eff12;
        public GLoader Eff23;
        public GLoader Eff13;
        public GLoader bagsLod;
        public GTextField StarLevel;
        public GLoader Slelctbg;
        public const string URL = "ui://use7blkkqgn28p";

        public static GridItem CreateInstance()
        {
            return (GridItem)UIPackage.CreateObject("BaseRes", "GridItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            bg = (GLoader)GetChild("bg");
            Eff21 = (GLoader)GetChild("Eff21");
            Eff11 = (GLoader)GetChild("Eff11");
            item = (GLoader)GetChild("item");
            title = (GTextField)GetChild("title");
            Eff22 = (GLoader)GetChild("Eff22");
            Eff12 = (GLoader)GetChild("Eff12");
            Eff23 = (GLoader)GetChild("Eff23");
            Eff13 = (GLoader)GetChild("Eff13");
            bagsLod = (GLoader)GetChild("bagsLod");
            StarLevel = (GTextField)GetChild("StarLevel");
            Slelctbg = (GLoader)GetChild("Slelctbg");
        }
    }
}