/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RankTipsBtn : GButton
    {
        public Controller button;
        public GImage Img8777c7;
        public GImage Img87886l;
        public const string URL = "ui://jk0io98jkn5zzs";

        public static RankTipsBtn CreateInstance()
        {
            return (RankTipsBtn)UIPackage.CreateObject("UIRes", "RankTipsBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img8777c7 = (GImage)GetChild("Img8777c7");
            Img87886l = (GImage)GetChild("Img87886l");
        }
    }
}