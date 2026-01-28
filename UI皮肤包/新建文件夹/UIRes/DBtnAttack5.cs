/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAttack5 : GButton
    {
        public GLoader skill;
        public GTextField name;
        public GImage mask;
        public GLoader lock5;
        public GTextField time;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b1fh";

        public static DBtnAttack5 CreateInstance()
        {
            return (DBtnAttack5)UIPackage.CreateObject("UIRes", "DBtnAttack5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
            mask = (GImage)GetChild("mask");
            lock5 = (GLoader)GetChild("lock5");
            time = (GTextField)GetChild("time");
            select = GetTransition("select");
        }
    }
}