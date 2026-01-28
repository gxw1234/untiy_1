/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAuto : GButton
    {
        public Controller button;
        public GImage Img95ft4;
        public GImage Img96ur1;
        public GLoader AutoAni;
        public Transition select;
        public const string URL = "ui://jk0io98jldxan23c";

        public static DBtnAuto CreateInstance()
        {
            return (DBtnAuto)UIPackage.CreateObject("UIRes", "DBtnAuto");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img95ft4 = (GImage)GetChild("Img95ft4");
            Img96ur1 = (GImage)GetChild("Img96ur1");
            AutoAni = (GLoader)GetChild("AutoAni");
            select = GetTransition("select");
        }
    }
}