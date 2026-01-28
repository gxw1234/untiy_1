/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAttack2 : GButton
    {
        public GLoader skill;
        public GTextField name;
        public GImage mask;
        public GLoader lock2;
        public GTextField time;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b1fa";

        public static DBtnAttack2 CreateInstance()
        {
            return (DBtnAttack2)UIPackage.CreateObject("UIRes", "DBtnAttack2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
            mask = (GImage)GetChild("mask");
            lock2 = (GLoader)GetChild("lock2");
            time = (GTextField)GetChild("time");
            select = GetTransition("select");
        }
    }
}