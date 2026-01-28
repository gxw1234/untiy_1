/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class MonStyRadioBtn : GButton
    {
        public Controller button;
        public GImage Img611p2h;
        public GImage Img610074;
        public GTextField ChatEdit38;
        public const string URL = "ui://jk0io98jkn5z13l";

        public static MonStyRadioBtn CreateInstance()
        {
            return (MonStyRadioBtn)UIPackage.CreateObject("UIRes", "MonStyRadioBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img611p2h = (GImage)GetChild("Img611p2h");
            Img610074 = (GImage)GetChild("Img610074");
            ChatEdit38 = (GTextField)GetChild("ChatEdit38");
        }
    }
}