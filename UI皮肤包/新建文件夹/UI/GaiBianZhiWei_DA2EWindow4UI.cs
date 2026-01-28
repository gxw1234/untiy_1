/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class GaiBianZhiWei_DA2EWindow4UI : GComponent
    {
        public Controller CRadios;
        public GImage DA2EWindow4;
        public GTextField ChatEdit20;
        public GButton BtnPosCancle;
        public GButton BtnConfirm;
        public GButton BtnPresident;
        public GButton BtnDePresident;
        public GTextField ChatEdit22;
        public GTextField ChatEdit24;
        public GTextField EditPoitionText;
        public GButton BtnGuildTMem;
        public GTextField ChatEdit50;
        public const string URL = "ui://jyvofh5ekn5z18b";

        public static GaiBianZhiWei_DA2EWindow4UI CreateInstance()
        {
            return (GaiBianZhiWei_DA2EWindow4UI)UIPackage.CreateObject("UI", "改变职位_DA2EWindow4UI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CRadios = GetController("CRadios");
            DA2EWindow4 = (GImage)GetChild("DA2EWindow4");
            ChatEdit20 = (GTextField)GetChild("ChatEdit20");
            BtnPosCancle = (GButton)GetChild("BtnPosCancle");
            BtnConfirm = (GButton)GetChild("BtnConfirm");
            BtnPresident = (GButton)GetChild("BtnPresident");
            BtnDePresident = (GButton)GetChild("BtnDePresident");
            ChatEdit22 = (GTextField)GetChild("ChatEdit22");
            ChatEdit24 = (GTextField)GetChild("ChatEdit24");
            EditPoitionText = (GTextField)GetChild("EditPoitionText");
            BtnGuildTMem = (GButton)GetChild("BtnGuildTMem");
            ChatEdit50 = (GTextField)GetChild("ChatEdit50");
        }
    }
}