/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TaskAndRanksPanel : GComponent
    {
        public Controller CPages;
        public GImage n1;
        public DA2ESimpleButton1 DA2ESimpleButton1;
        public DTabBtnHums DTabBtnHums;
        public DTabBtnMob DTabBtnMobs;
        public DTabBtnTaks DTabBtnTaks;
        public DTabBtnRanks DTabBtnRanks;
        public DA2EPage1 DA2EPage1;
        public DA2EPage2 DA2EPage2;
        public DA2EPage3 DA2EPage3;
        public DA2EPage4 DA2EPage4;
        public RefreshBtn RefreshBtn;
        public Transition go;
        public const string URL = "ui://jk0io98jtd9ga";

        public static TaskAndRanksPanel CreateInstance()
        {
            return (TaskAndRanksPanel)UIPackage.CreateObject("UIRes", "TaskAndRanksPanel");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CPages = GetController("CPages");
            n1 = (GImage)GetChild("n1");
            DA2ESimpleButton1 = (DA2ESimpleButton1)GetChild("DA2ESimpleButton1");
            DTabBtnHums = (DTabBtnHums)GetChild("DTabBtnHums");
            DTabBtnMobs = (DTabBtnMob)GetChild("DTabBtnMobs");
            DTabBtnTaks = (DTabBtnTaks)GetChild("DTabBtnTaks");
            DTabBtnRanks = (DTabBtnRanks)GetChild("DTabBtnRanks");
            DA2EPage1 = (DA2EPage1)GetChild("DA2EPage1");
            DA2EPage2 = (DA2EPage2)GetChild("DA2EPage2");
            DA2EPage3 = (DA2EPage3)GetChild("DA2EPage3");
            DA2EPage4 = (DA2EPage4)GetChild("DA2EPage4");
            RefreshBtn = (RefreshBtn)GetChild("RefreshBtn");
            go = GetTransition("go");
        }
    }
}