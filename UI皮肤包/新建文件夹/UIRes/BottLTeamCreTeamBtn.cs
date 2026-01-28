/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottLTeamCreTeamBtn : GButton
    {
        public Controller button;
        public GImage Img576px1;
        public GImage Img577l30;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jtd9gg";

        public static BottLTeamCreTeamBtn CreateInstance()
        {
            return (BottLTeamCreTeamBtn)UIPackage.CreateObject("UIRes", "BottLTeamCreTeamBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img576px1 = (GImage)GetChild("Img576px1");
            Img577l30 = (GImage)GetChild("Img577l30");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}