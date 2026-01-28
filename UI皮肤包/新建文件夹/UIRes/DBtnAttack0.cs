/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAttack0 : GButton
    {
        public GLoader skill;
        public GImage mask;
        public GTextField name;
        public GLoader lock0;
        public GTextField time;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b1fd";

        public static DBtnAttack0 CreateInstance()
        {
            return (DBtnAttack0)UIPackage.CreateObject("UIRes", "DBtnAttack0");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            skill = (GLoader)GetChild("skill");
            mask = (GImage)GetChild("mask");
            name = (GTextField)GetChild("name");
            lock0 = (GLoader)GetChild("lock0");
            time = (GTextField)GetChild("time");
            select = GetTransition("select");
        }
    }
}