/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAttack9 : GButton
    {
        public GLoader skill;
        public GTextField name;
        public GImage mask;
        public GLoader lock1;
        public GTextField time;
        public Transition select;
        public const string URL = "ui://jk0io98jj67ugvn2z5";

        public static DBtnAttack9 CreateInstance()
        {
            return (DBtnAttack9)UIPackage.CreateObject("UIRes", "DBtnAttack9");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
            mask = (GImage)GetChild("mask");
            lock1 = (GLoader)GetChild("lock1");
            time = (GTextField)GetChild("time");
            select = GetTransition("select");
        }
    }
}