/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAttack12 : GButton
    {
        public GLoader skill;
        public GTextField name;
        public GImage mask;
        public GLoader lock4;
        public GTextField time;
        public Transition select;
        public const string URL = "ui://jk0io98jj67ugvn2z8";

        public static DBtnAttack12 CreateInstance()
        {
            return (DBtnAttack12)UIPackage.CreateObject("UIRes", "DBtnAttack12");
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