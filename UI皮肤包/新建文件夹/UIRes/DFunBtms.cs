/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DFunBtms : GComponent
    {
        public Controller CRadios;
        public DBtnWindow2 DBtnsWindow2;
        public DBtnsWindow DBtnsWindow;
        public DBtnShow DBtnShow;
        public GLoader BagFull;
        public NoteBagWin NoteBagWin;
        public RigPromoteUI RigPromoteUI;
        public GList RigFunctionList;
        public RigPetUI RigPetUI;
        public DBtnExit DBtnExit2;
        public DBtnFollow DBtnFollow;
        public DBtnHero DBtnHero;
        public DBtnRiding n14;
        public DBtnControl n15;
        public DBtnBag DBtnBag;
        public DBtnState DBtnState;
        public DBtnSkill n11;
        public DBtnMissions n12;
        public DBtnaAutomatic DBtnaAutomatic;
        public DBtnPick n19;
        public Transition come;
        public const string URL = "ui://jk0io98jk02tn1v2";

        public static DFunBtms CreateInstance()
        {
            return (DFunBtms)UIPackage.CreateObject("UIRes", "DFunBtms");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CRadios = GetController("CRadios");
            DBtnsWindow2 = (DBtnWindow2)GetChild("DBtnsWindow2");
            DBtnsWindow = (DBtnsWindow)GetChild("DBtnsWindow");
            DBtnShow = (DBtnShow)GetChild("DBtnShow");
            BagFull = (GLoader)GetChild("BagFull");
            NoteBagWin = (NoteBagWin)GetChild("NoteBagWin");
            RigPromoteUI = (RigPromoteUI)GetChild("RigPromoteUI");
            RigFunctionList = (GList)GetChild("RigFunctionList");
            RigPetUI = (RigPetUI)GetChild("RigPetUI");
            DBtnExit2 = (DBtnExit)GetChild("DBtnExit2");
            DBtnFollow = (DBtnFollow)GetChild("DBtnFollow");
            DBtnHero = (DBtnHero)GetChild("DBtnHero");
            n14 = (DBtnRiding)GetChild("n14");
            n15 = (DBtnControl)GetChild("n15");
            DBtnBag = (DBtnBag)GetChild("DBtnBag");
            DBtnState = (DBtnState)GetChild("DBtnState");
            n11 = (DBtnSkill)GetChild("n11");
            n12 = (DBtnMissions)GetChild("n12");
            DBtnaAutomatic = (DBtnaAutomatic)GetChild("DBtnaAutomatic");
            n19 = (DBtnPick)GetChild("n19");
            come = GetTransition("come");
        }
    }
}