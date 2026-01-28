/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DRBGuild : GButton
    {
        public Controller button;
        public GImage Img305y27;
        public GImage Img304hj8;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jj3e21kk";

        public static DRBGuild CreateInstance()
        {
            return (DRBGuild)UIPackage.CreateObject("UIRes", "DRBGuild");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img305y27 = (GImage)GetChild("Img305y27");
            Img304hj8 = (GImage)GetChild("Img304hj8");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}