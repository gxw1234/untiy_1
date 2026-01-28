/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAttack4 : GButton
    {
        public GLoader skill;
        public GTextField name;
        public GImage mask;
        public GLoader lock4;
        public GTextField time;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b1fg";

        public static DBtnAttack4 CreateInstance()
        {
            return (DBtnAttack4)UIPackage.CreateObject("UIRes", "DBtnAttack4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
            mask = (GImage)GetChild("mask");
            lock4 = (GLoader)GetChild("lock4");
            time = (GTextField)GetChild("time");
            select = GetTransition("select");
        }
    }
}