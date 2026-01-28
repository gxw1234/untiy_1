/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DModekMenu : GComponent
    {
        public Controller CRadios;
        public DModelMenuItem0 DModelMenuItem0;
        public DModelMenuItem1 DModelMenuItem1;
        public DModelMenuItem2 DModelMenuItem2;
        public DModelMenuItem3 DModelMenuItem3;
        public DModelMenuItem4 DModelMenuItem4;
        public DModelMenuItem5 DModelMenuItem5;
        public DModelMenuItem6 DModelMenuItem6;
        public DModelMenuItem7 DModelMenuItem7;
        public const string URL = "ui://jk0io98jv9b1g4";

        public static DModekMenu CreateInstance()
        {
            return (DModekMenu)UIPackage.CreateObject("UIRes", "DModekMenu");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CRadios = GetController("CRadios");
            DModelMenuItem0 = (DModelMenuItem0)GetChild("DModelMenuItem0");
            DModelMenuItem1 = (DModelMenuItem1)GetChild("DModelMenuItem1");
            DModelMenuItem2 = (DModelMenuItem2)GetChild("DModelMenuItem2");
            DModelMenuItem3 = (DModelMenuItem3)GetChild("DModelMenuItem3");
            DModelMenuItem4 = (DModelMenuItem4)GetChild("DModelMenuItem4");
            DModelMenuItem5 = (DModelMenuItem5)GetChild("DModelMenuItem5");
            DModelMenuItem6 = (DModelMenuItem6)GetChild("DModelMenuItem6");
            DModelMenuItem7 = (DModelMenuItem7)GetChild("DModelMenuItem7");
        }
    }
}