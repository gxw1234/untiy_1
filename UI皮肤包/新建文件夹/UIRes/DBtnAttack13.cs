/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAttack13 : GButton
    {
        public GLoader skill;
        public GTextField name;
        public GImage mask;
        public GLoader lock5;
        public GTextField time;
        public Transition select;
        public const string URL = "ui://jk0io98jj67ugvn2z9";

        public static DBtnAttack13 CreateInstance()
        {
            return (DBtnAttack13)UIPackage.CreateObject("UIRes", "DBtnAttack13");
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