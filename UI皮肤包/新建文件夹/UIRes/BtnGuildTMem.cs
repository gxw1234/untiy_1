/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnGuildTMem : GButton
    {
        public Controller button;
        public GImage Img176gv4;
        public GImage Img17727g;
        public const string URL = "ui://jk0io98jkn5z174";

        public static BtnGuildTMem CreateInstance()
        {
            return (BtnGuildTMem)UIPackage.CreateObject("UIRes", "BtnGuildTMem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img176gv4 = (GImage)GetChild("Img176gv4");
            Img17727g = (GImage)GetChild("Img17727g");
        }
    }
}