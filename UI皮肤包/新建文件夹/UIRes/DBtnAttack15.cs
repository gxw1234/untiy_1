/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAttack15 : GButton
    {
        public GLoader skill;
        public GTextField name;
        public GImage mask;
        public GLoader lock7;
        public GTextField time;
        public Transition select;
        public const string URL = "ui://jk0io98jj67ugvn2zb";

        public static DBtnAttack15 CreateInstance()
        {
            return (DBtnAttack15)UIPackage.CreateObject("UIRes", "DBtnAttack15");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
            mask = (GImage)GetChild("mask");
            lock7 = (GLoader)GetChild("lock7");
            time = (GTextField)GetChild("time");
            select = GetTransition("select");
        }
    }
}