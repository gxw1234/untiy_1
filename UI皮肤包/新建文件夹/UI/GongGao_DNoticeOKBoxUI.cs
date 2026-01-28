/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class GongGao_DNoticeOKBoxUI : GComponent
    {
        public GImage DNoticeOKBox;
        public GButton DBtnOK;
        public GRichTextField DNoticeOKBoxText;
        public const string URL = "ui://jyvofh5ekn5z190";

        public static GongGao_DNoticeOKBoxUI CreateInstance()
        {
            return (GongGao_DNoticeOKBoxUI)UIPackage.CreateObject("UI", "公告_DNoticeOKBoxUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DNoticeOKBox = (GImage)GetChild("DNoticeOKBox");
            DBtnOK = (GButton)GetChild("DBtnOK");
            DNoticeOKBoxText = (GRichTextField)GetChild("DNoticeOKBoxText");
        }
    }
}