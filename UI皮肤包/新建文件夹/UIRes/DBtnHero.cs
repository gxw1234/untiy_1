/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnHero : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public const string URL = "ui://jk0io98jmwatgvn2yo";

        public static DBtnHero CreateInstance()
        {
            return (DBtnHero)UIPackage.CreateObject("UIRes", "DBtnHero");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
        }
    }
}