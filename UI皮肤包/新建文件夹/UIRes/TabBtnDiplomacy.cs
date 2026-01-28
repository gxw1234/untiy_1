/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TabBtnDiplomacy : GButton
    {
        public Controller button;
        public GImage Img263lgp;
        public GImage Img262u3v;
        public const string URL = "ui://jk0io98jkn5z17d";

        public static TabBtnDiplomacy CreateInstance()
        {
            return (TabBtnDiplomacy)UIPackage.CreateObject("UIRes", "TabBtnDiplomacy");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img263lgp = (GImage)GetChild("Img263lgp");
            Img262u3v = (GImage)GetChild("Img262u3v");
        }
    }
}