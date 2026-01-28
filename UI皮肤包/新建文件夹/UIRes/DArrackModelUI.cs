/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DArrackModelUI : GComponent
    {
        public GGraph n0;
        public DBtnAttack2 DBtnAttack2;
        public DBtnSelMonster DBtnSelMonster;
        public DBtnSelPlay DBtnSelPlay;
        public DBtnAttack0 DBtnAttack0;
        public DBtnAttack1 DBtnAttack1;
        public DBtnAttack3 DBtnAttack3;
        public DBtnAttack4 DBtnAttack4;
        public DBtnAttack5 DBtnAttack5;
        public DBtnAttack6 DBtnAttack6;
        public DBtnAttack7 DBtnAttack7;
        public DBtnAttack8 DBtnAttack8;
        public DTargetBtn DTargetBtn;
        public TargetCom TargetCom;
        public TargetListItem TargetListItem0;
        public TargetListItem TargetListItem1;
        public TargetListItem TargetListItem2;
        public DBtnStorm DBtnStorm;
        public DBtnAttack9 DBtnAttack9;
        public DBtnAttack10 DBtnAttack10;
        public DBtnAttack11 DBtnAttack11;
        public DBtnAttack12 DBtnAttack12;
        public DBtnAttack13 DBtnAttack13;
        public DBtnAttack14 DBtnAttack14;
        public DBtnAttack15 DBtnAttack15;
        public DBtnAttack16 DBtnAttack16;
        public ChangeSkill ChangeSkill;
        public Fish n24;
        public Meet n25;
        public Ore n26;
        public ChangeSKILL ChangeSKILL;
        public Transition GO;
        public Transition ChangeSkill_2;
        public Transition ChangeSKILL_2;
        public const string URL = "ui://jk0io98jv9b1g0";

        public static DArrackModelUI CreateInstance()
        {
            return (DArrackModelUI)UIPackage.CreateObject("UIRes", "DArrackModelUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GGraph)GetChild("n0");
            DBtnAttack2 = (DBtnAttack2)GetChild("DBtnAttack2");
            DBtnSelMonster = (DBtnSelMonster)GetChild("DBtnSelMonster");
            DBtnSelPlay = (DBtnSelPlay)GetChild("DBtnSelPlay");
            DBtnAttack0 = (DBtnAttack0)GetChild("DBtnAttack0");
            DBtnAttack1 = (DBtnAttack1)GetChild("DBtnAttack1");
            DBtnAttack3 = (DBtnAttack3)GetChild("DBtnAttack3");
            DBtnAttack4 = (DBtnAttack4)GetChild("DBtnAttack4");
            DBtnAttack5 = (DBtnAttack5)GetChild("DBtnAttack5");
            DBtnAttack6 = (DBtnAttack6)GetChild("DBtnAttack6");
            DBtnAttack7 = (DBtnAttack7)GetChild("DBtnAttack7");
            DBtnAttack8 = (DBtnAttack8)GetChild("DBtnAttack8");
            DTargetBtn = (DTargetBtn)GetChild("DTargetBtn");
            TargetCom = (TargetCom)GetChild("TargetCom");
            TargetListItem0 = (TargetListItem)GetChild("TargetListItem0");
            TargetListItem1 = (TargetListItem)GetChild("TargetListItem1");
            TargetListItem2 = (TargetListItem)GetChild("TargetListItem2");
            DBtnStorm = (DBtnStorm)GetChild("DBtnStorm");
            DBtnAttack9 = (DBtnAttack9)GetChild("DBtnAttack9");
            DBtnAttack10 = (DBtnAttack10)GetChild("DBtnAttack10");
            DBtnAttack11 = (DBtnAttack11)GetChild("DBtnAttack11");
            DBtnAttack12 = (DBtnAttack12)GetChild("DBtnAttack12");
            DBtnAttack13 = (DBtnAttack13)GetChild("DBtnAttack13");
            DBtnAttack14 = (DBtnAttack14)GetChild("DBtnAttack14");
            DBtnAttack15 = (DBtnAttack15)GetChild("DBtnAttack15");
            DBtnAttack16 = (DBtnAttack16)GetChild("DBtnAttack16");
            ChangeSkill = (ChangeSkill)GetChild("ChangeSkill");
            n24 = (Fish)GetChild("n24");
            n25 = (Meet)GetChild("n25");
            n26 = (Ore)GetChild("n26");
            ChangeSKILL = (ChangeSKILL)GetChild("ChangeSKILL");
            GO = GetTransition("GO");
            ChangeSkill_2 = GetTransition("ChangeSkill");
            ChangeSKILL_2 = GetTransition("ChangeSKILL");
        }
    }
}