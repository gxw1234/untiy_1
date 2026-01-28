/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class RenWu_DA2EWindow1UI : GComponent
    {
        public Controller CRadios;
        public GImage DA2EWindow1;
        public GComponent frame;
        public GButton BtnMainTask;
        public GButton BtnBranch;
        public GButton BtnGuide;
        public GButton BtnFate;
        public GButton BtnClose;
        public GRichTextField ItemShowInfo;
        public GTree DA2EGrid3;
        public GComponent DMissionDesc;
        public GImage TaskFontImg;
        public const string URL = "ui://jyvofh5ef4m1c";

        public static RenWu_DA2EWindow1UI CreateInstance()
        {
            return (RenWu_DA2EWindow1UI)UIPackage.CreateObject("UI", "任务_DA2EWindow1UI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CRadios = GetController("CRadios");
            DA2EWindow1 = (GImage)GetChild("DA2EWindow1");
            frame = (GComponent)GetChild("frame");
            BtnMainTask = (GButton)GetChild("BtnMainTask");
            BtnBranch = (GButton)GetChild("BtnBranch");
            BtnGuide = (GButton)GetChild("BtnGuide");
            BtnFate = (GButton)GetChild("BtnFate");
            BtnClose = (GButton)GetChild("BtnClose");
            ItemShowInfo = (GRichTextField)GetChild("ItemShowInfo");
            DA2EGrid3 = (GTree)GetChild("DA2EGrid3");
            DMissionDesc = (GComponent)GetChild("DMissionDesc");
            TaskFontImg = (GImage)GetChild("TaskFontImg");
        }
    }
}