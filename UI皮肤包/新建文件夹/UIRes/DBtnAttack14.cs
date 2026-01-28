/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAttack14 : GButton
    {
        public GLoader skill;
        public GTextField name;
        public GImage mask;
        public GLoader lock6;
        public GTextField time;
        public Transition select;
        public const string URL = "ui://jk0io98jj67ugvn2za";

        public static DBtnAttack14 CreateInstance()
        {
            return (DBtnAttack14)UIPackage.CreateObject("UIRes", "DBtnAttack14");
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