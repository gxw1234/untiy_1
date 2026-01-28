/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnExitGuild : GButton
    {
        public Controller button;
        public GImage Img191q71;
        public GImage Img1920b8;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z17l";

        public static BtnExitGuild CreateInstance()
        {
            return (BtnExitGuild)UIPackage.CreateObject("UIRes", "BtnExitGuild");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img191q71 = (GImage)GetChild("Img191q71");
            Img1920b8 = (GImage)GetChild("Img1920b8");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}