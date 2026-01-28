/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class UpgradeDialog : GComponent
    {
        public GImage bg;
        public GComponent frame;
        public GComponent UpgradeCell1;
        public GComponent UpgradeCell2;
        public GComponent UpgradeCell3;
        public GButton BtnUpgradeDialogClose;
        public GButton BtnUpgrade;
        public const string URL = "ui://jyvofh5ehdg7vn2se";

        public static UpgradeDialog CreateInstance()
        {
            return (UpgradeDialog)UIPackage.CreateObject("UI", "UpgradeDialog");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            frame = (GComponent)GetChild("frame");
            UpgradeCell1 = (GComponent)GetChild("UpgradeCell1");
            UpgradeCell2 = (GComponent)GetChild("UpgradeCell2");
            UpgradeCell3 = (GComponent)GetChild("UpgradeCell3");
            BtnUpgradeDialogClose = (GButton)GetChild("BtnUpgradeDialogClose");
            BtnUpgrade = (GButton)GetChild("BtnUpgrade");
        }
    }
}