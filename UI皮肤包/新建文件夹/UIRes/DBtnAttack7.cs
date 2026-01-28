/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAttack7 : GButton
    {
        public GLoader skill;
        public GTextField name;
        public GImage mask;
        public GLoader lock7;
        public GTextField time;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b1fj";

        public static DBtnAttack7 CreateInstance()
        {
            return (DBtnAttack7)UIPackage.CreateObject("UIRes", "DBtnAttack7");
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