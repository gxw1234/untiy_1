/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAttack8 : GButton
    {
        public GLoader skill;
        public GTextField name;
        public GImage mask;
        public GLoader lock8;
        public GTextField time;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b1fk";

        public static DBtnAttack8 CreateInstance()
        {
            return (DBtnAttack8)UIPackage.CreateObject("UIRes", "DBtnAttack8");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
            mask = (GImage)GetChild("mask");
            lock8 = (GLoader)GetChild("lock8");
            time = (GTextField)GetChild("time");
            select = GetTransition("select");
        }
    }
}