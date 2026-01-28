/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class DGameShopDlg : GComponent
    {
        public GImage BG;
        public GComponent frame;
        public GButton CloseButton;
        public GTextField Title;
        public GButton ShopButton1;
        public GButton ShopButton2;
        public GComponent GameShopPanel;
        public GComponent BuyPanel;
        public const string URL = "ui://jyvofh5em9og0";

        public static DGameShopDlg CreateInstance()
        {
            return (DGameShopDlg)UIPackage.CreateObject("UI", "DGameShopDlg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            BG = (GImage)GetChild("BG");
            frame = (GComponent)GetChild("frame");
            CloseButton = (GButton)GetChild("CloseButton");
            Title = (GTextField)GetChild("Title");
            ShopButton1 = (GButton)GetChild("ShopButton1");
            ShopButton2 = (GButton)GetChild("ShopButton2");
            GameShopPanel = (GComponent)GetChild("GameShopPanel");
            BuyPanel = (GComponent)GetChild("BuyPanel");
        }
    }
}