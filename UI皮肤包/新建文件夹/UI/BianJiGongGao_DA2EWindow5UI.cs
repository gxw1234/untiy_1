/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class BianJiGongGao_DA2EWindow5UI : GComponent
    {
        public GImage DA2EWindow5;
        public GTextField ChatEdit25;
        public GButton BtnNoticeSave;
        public GButton BtnNoticeCancle;
        public GTextInput EditNoticeTxt;
        public const string URL = "ui://jyvofh5ekn5z18c";

        public static BianJiGongGao_DA2EWindow5UI CreateInstance()
        {
            return (BianJiGongGao_DA2EWindow5UI)UIPackage.CreateObject("UI", "编辑公告_DA2EWindow5UI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow5 = (GImage)GetChild("DA2EWindow5");
            ChatEdit25 = (GTextField)GetChild("ChatEdit25");
            BtnNoticeSave = (GButton)GetChild("BtnNoticeSave");
            BtnNoticeCancle = (GButton)GetChild("BtnNoticeCancle");
            EditNoticeTxt = (GTextInput)GetChild("EditNoticeTxt");
        }
    }
}