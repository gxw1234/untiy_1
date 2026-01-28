/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAttack11 : GButton
    {
        public GLoader skill;
        public GTextField name;
        public GImage mask;
        public GLoader lock3;
        public GTextField time;
        public Transition select;
        public const string URL = "ui://jk0io98jj67ugvn2z7";

        public static DBtnAttack11 CreateInstance()
        {
            return (DBtnAttack11)UIPackage.CreateObject("UIRes", "DBtnAttack11");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            name = (GTextField)GetChild("name");
            mask = (GImage)GetChild("mask");
            lock3 = (GLoader)GetChild("lock3");
            time = (GTextField)GetChild("time");
            select = GetTransition("select");
        }
    }
}