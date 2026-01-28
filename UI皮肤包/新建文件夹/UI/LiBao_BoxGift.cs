/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class LiBao_BoxGift : GComponent
    {
        public GImage bg;
        public GImage n42;
        public GButton CodeCloseBtn;
        public GTextField giftTipsText;
        public GTextField giftTipsText2;
        public GImage inputBg;
        public GTextInput cdkeynum;
        public GButton BtnToBox;
        public GTextField tobox;
        public GButton btnGet;
        public GList listItem;
        public GList listPlatform;
        public GImage imgHadGet;
        public GImage boxgifttips;
        public const string URL = "ui://jyvofh5ejwn4vn2s0";

        public static LiBao_BoxGift CreateInstance()
        {
            return (LiBao_BoxGift)UIPackage.CreateObject("UI", "礼包_BoxGift");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            n42 = (GImage)GetChild("n42");
            CodeCloseBtn = (GButton)GetChild("CodeCloseBtn");
            giftTipsText = (GTextField)GetChild("giftTipsText");
            giftTipsText2 = (GTextField)GetChild("giftTipsText2");
            inputBg = (GImage)GetChild("inputBg");
            cdkeynum = (GTextInput)GetChild("cdkeynum");
            BtnToBox = (GButton)GetChild("BtnToBox");
            tobox = (GTextField)GetChild("tobox");
            btnGet = (GButton)GetChild("btnGet");
            listItem = (GList)GetChild("listItem");
            listPlatform = (GList)GetChild("listPlatform");
            imgHadGet = (GImage)GetChild("imgHadGet");
            boxgifttips = (GImage)GetChild("boxgifttips");
        }
    }
}