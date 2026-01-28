/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoading
{
    public partial class XuanFu_NoticeUIWinUI : GComponent
    {
        public GImage NoticeUIWin;
        public GButton ConfirmBtn;
        public GList DA2EGrid1;
        public GList DA2EGrid2;
        public GTextField TitleName;
        public const string URL = "ui://up3anxyrk2h33y";

        public static XuanFu_NoticeUIWinUI CreateInstance()
        {
            return (XuanFu_NoticeUIWinUI)UIPackage.CreateObject("UILoading", "选服_NoticeUIWinUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            NoticeUIWin = (GImage)GetChild("NoticeUIWin");
            ConfirmBtn = (GButton)GetChild("ConfirmBtn");
            DA2EGrid1 = (GList)GetChild("DA2EGrid1");
            DA2EGrid2 = (GList)GetChild("DA2EGrid2");
            TitleName = (GTextField)GetChild("TitleName");
        }
    }
}