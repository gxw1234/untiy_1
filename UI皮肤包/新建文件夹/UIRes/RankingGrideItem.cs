/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RankingGrideItem : GButton
    {
        public Controller button;
        public GImage Img881evv;
        public GImage Img876xew;
        public GTextField RankindexText;
        public GLoader RankListLoadIcons;
        public GTextField RankListItemText1;
        public GTextField RankListItemText2;
        public GTextField RankListItemText3;
        public const string URL = "ui://jk0io98jkn5z100";

        public static RankingGrideItem CreateInstance()
        {
            return (RankingGrideItem)UIPackage.CreateObject("UIRes", "RankingGrideItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img881evv = (GImage)GetChild("Img881evv");
            Img876xew = (GImage)GetChild("Img876xew");
            RankindexText = (GTextField)GetChild("RankindexText");
            RankListLoadIcons = (GLoader)GetChild("RankListLoadIcons");
            RankListItemText1 = (GTextField)GetChild("RankListItemText1");
            RankListItemText2 = (GTextField)GetChild("RankListItemText2");
            RankListItemText3 = (GTextField)GetChild("RankListItemText3");
        }
    }
}