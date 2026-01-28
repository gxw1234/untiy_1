/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottLefMobItem : GButton
    {
        public Controller button;
        public GImage Img8582ui;
        public GImage DA2EIMAGE2;
        public GLoader BottLTeamloodsIcons;
        public GTextField BottLTeamNames;
        public BottLTeamloods BottLTeamloods;
        public const string URL = "ui://jk0io98js46a1b";

        public static BottLefMobItem CreateInstance()
        {
            return (BottLefMobItem)UIPackage.CreateObject("UIRes", "BottLefMobItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img8582ui = (GImage)GetChild("Img8582ui");
            DA2EIMAGE2 = (GImage)GetChild("DA2EIMAGE2");
            BottLTeamloodsIcons = (GLoader)GetChild("BottLTeamloodsIcons");
            BottLTeamNames = (GTextField)GetChild("BottLTeamNames");
            BottLTeamloods = (BottLTeamloods)GetChild("BottLTeamloods");
        }
    }
}