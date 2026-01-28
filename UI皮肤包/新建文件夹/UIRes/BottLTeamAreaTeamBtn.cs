/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottLTeamAreaTeamBtn : GButton
    {
        public Controller button;
        public GImage Img578uni;
        public GImage Img57934d;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jtd9gh";

        public static BottLTeamAreaTeamBtn CreateInstance()
        {
            return (BottLTeamAreaTeamBtn)UIPackage.CreateObject("UIRes", "BottLTeamAreaTeamBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img578uni = (GImage)GetChild("Img578uni");
            Img57934d = (GImage)GetChild("Img57934d");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}