/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class YouXianSheZhi_FirstSetUI : GComponent
    {
        public GImage n0;
        public GImage n24;
        public GRichTextField tilte;
        public GImage n17;
        public GImage n15;
        public GRichTextField n16;
        public GList PalyerList;
        public GButton CloseButton;
        public GComponent targetPos0;
        public GComponent targetPos1;
        public GComponent targetPos2;
        public GButton BtnRestKey;
        public GButton BtnResetFirst;
        public GButton BtnHelp;
        public GRichTextField n26;
        public const string URL = "ui://jyvofh5es3366";

        public static YouXianSheZhi_FirstSetUI CreateInstance()
        {
            return (YouXianSheZhi_FirstSetUI)UIPackage.CreateObject("UI", "优先设置_FirstSetUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            n24 = (GImage)GetChild("n24");
            tilte = (GRichTextField)GetChild("tilte");
            n17 = (GImage)GetChild("n17");
            n15 = (GImage)GetChild("n15");
            n16 = (GRichTextField)GetChild("n16");
            PalyerList = (GList)GetChild("PalyerList");
            CloseButton = (GButton)GetChild("CloseButton");
            targetPos0 = (GComponent)GetChild("targetPos0");
            targetPos1 = (GComponent)GetChild("targetPos1");
            targetPos2 = (GComponent)GetChild("targetPos2");
            BtnRestKey = (GButton)GetChild("BtnRestKey");
            BtnResetFirst = (GButton)GetChild("BtnResetFirst");
            BtnHelp = (GButton)GetChild("BtnHelp");
            n26 = (GRichTextField)GetChild("n26");
        }
    }
}