/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottGuildAniBtn : GButton
    {
        public Controller button;
        public GImage Img583x17;
        public GImage Img58380e;
        public const string URL = "ui://jk0io98jv9b11q";

        public static BottGuildAniBtn CreateInstance()
        {
            return (BottGuildAniBtn)UIPackage.CreateObject("UIRes", "BottGuildAniBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img583x17 = (GImage)GetChild("Img583x17");
            Img58380e = (GImage)GetChild("Img58380e");
        }
    }
}