/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CompetePriceCancleBtn : GButton
    {
        public Controller button;
        public GImage Img265x1o;
        public GImage Img266p7g;
        public GTextField ChatEdit59;
        public const string URL = "ui://jk0io98jkn5z132";

        public static CompetePriceCancleBtn CreateInstance()
        {
            return (CompetePriceCancleBtn)UIPackage.CreateObject("UIRes", "CompetePriceCancleBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265x1o = (GImage)GetChild("Img265x1o");
            Img266p7g = (GImage)GetChild("Img266p7g");
            ChatEdit59 = (GTextField)GetChild("ChatEdit59");
        }
    }
}