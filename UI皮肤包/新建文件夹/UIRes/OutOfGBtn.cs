/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class OutOfGBtn : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public GImage n2;
        public GImage n3;
        public GTextField n4;
        public const string URL = "ui://jk0io98jj3e21ch";

        public static OutOfGBtn CreateInstance()
        {
            return (OutOfGBtn)UIPackage.CreateObject("UIRes", "OutOfGBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
            n2 = (GImage)GetChild("n2");
            n3 = (GImage)GetChild("n3");
            n4 = (GTextField)GetChild("n4");
        }
    }
}