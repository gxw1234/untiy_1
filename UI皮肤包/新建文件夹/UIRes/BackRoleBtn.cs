/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BackRoleBtn : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public GImage n2;
        public GImage n3;
        public GTextField title;
        public GImage n5;
        public GTextField text;
        public const string URL = "ui://jk0io98jgcp1n1q8";

        public static BackRoleBtn CreateInstance()
        {
            return (BackRoleBtn)UIPackage.CreateObject("UIRes", "BackRoleBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
            n2 = (GImage)GetChild("n2");
            n3 = (GImage)GetChild("n3");
            title = (GTextField)GetChild("title");
            n5 = (GImage)GetChild("n5");
            text = (GTextField)GetChild("text");
        }
    }
}