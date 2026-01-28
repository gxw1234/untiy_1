/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAttack6 : GButton
    {
        public GLoader skill;
        public GTextField name;
        public GImage mask;
        public GLoader lock6;
        public GTextField time;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b1fi";

        public static DBtnAttack6 CreateInstance()
        {
            return (DBtnAttack6)UIPackage.CreateObject("UIRes", "DBtnAttack6");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
            mask = (GImage)GetChild("mask");
            lock6 = (GLoader)GetChild("lock6");
            time = (GTextField)GetChild("time");
            select = GetTransition("select");
        }
    }
}