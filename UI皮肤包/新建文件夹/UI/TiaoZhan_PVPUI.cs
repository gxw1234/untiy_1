/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class TiaoZhan_PVPUI : GComponent
    {
        public GImage PVP_BG;
        public GComponent frame;
        public GRichTextField tipsText;
        public GButton CloseButton;
        public GComponent otherInfo;
        public GComponent myInfo;
        public GButton BtnSure;
        public GButton BtnCancel;
        public const string URL = "ui://jyvofh5es3360";

        public static TiaoZhan_PVPUI CreateInstance()
        {
            return (TiaoZhan_PVPUI)UIPackage.CreateObject("UI", "挑战_PVPUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            PVP_BG = (GImage)GetChild("PVP_BG");
            frame = (GComponent)GetChild("frame");
            tipsText = (GRichTextField)GetChild("tipsText");
            CloseButton = (GButton)GetChild("CloseButton");
            otherInfo = (GComponent)GetChild("otherInfo");
            myInfo = (GComponent)GetChild("myInfo");
            BtnSure = (GButton)GetChild("BtnSure");
            BtnCancel = (GButton)GetChild("BtnCancel");
        }
    }
}