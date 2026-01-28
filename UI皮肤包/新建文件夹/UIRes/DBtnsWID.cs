/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnsWID : GComponent
    {
        public Hero1 n3;
        public Hero2 n4;
        public Hero3 n5;
        public Mail n6;
        public Rech n7;
        public Guide n8;
        public Events n9;
        public Ranking n10;
        public BoxGiftBtn BoxGiftBtn;
        public const string URL = "ui://jk0io98jpnb5vn2so";

        public static DBtnsWID CreateInstance()
        {
            return (DBtnsWID)UIPackage.CreateObject("UIRes", "DBtnsWID");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n3 = (Hero1)GetChild("n3");
            n4 = (Hero2)GetChild("n4");
            n5 = (Hero3)GetChild("n5");
            n6 = (Mail)GetChild("n6");
            n7 = (Rech)GetChild("n7");
            n8 = (Guide)GetChild("n8");
            n9 = (Events)GetChild("n9");
            n10 = (Ranking)GetChild("n10");
            BoxGiftBtn = (BoxGiftBtn)GetChild("BoxGiftBtn");
        }
    }
}