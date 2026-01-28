/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class SellNameItem : GButton
    {
        public Controller button;
        public GImage Img61650g;
        public GImage Img6162v0;
        public GTextField Page2SellGoodNames;
        public GTextField ChatEdit16;
        public GTextField ChatEdit17;
        public GTextField ChatEdit18;
        public GLoader DA2ELoader8;
        public GTextField Page2ItemsReNums;
        public GLoader DA2ELoader7;
        public Page2SellGoodWin Page2SellGoodWin;
        public DA2EWindow3 DA2EWindow3;
        public DA2EWindow4 DA2EWindow4;
        public GTextField SelRiglGName;
        public const string URL = "ui://jk0io98jkn5z13o";

        public static SellNameItem CreateInstance()
        {
            return (SellNameItem)UIPackage.CreateObject("UIRes", "SellNameItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img61650g = (GImage)GetChild("Img61650g");
            Img6162v0 = (GImage)GetChild("Img6162v0");
            Page2SellGoodNames = (GTextField)GetChild("Page2SellGoodNames");
            ChatEdit16 = (GTextField)GetChild("ChatEdit16");
            ChatEdit17 = (GTextField)GetChild("ChatEdit17");
            ChatEdit18 = (GTextField)GetChild("ChatEdit18");
            DA2ELoader8 = (GLoader)GetChild("DA2ELoader8");
            Page2ItemsReNums = (GTextField)GetChild("Page2ItemsReNums");
            DA2ELoader7 = (GLoader)GetChild("DA2ELoader7");
            Page2SellGoodWin = (Page2SellGoodWin)GetChild("Page2SellGoodWin");
            DA2EWindow3 = (DA2EWindow3)GetChild("DA2EWindow3");
            DA2EWindow4 = (DA2EWindow4)GetChild("DA2EWindow4");
            SelRiglGName = (GTextField)GetChild("SelRiglGName");
        }
    }
}