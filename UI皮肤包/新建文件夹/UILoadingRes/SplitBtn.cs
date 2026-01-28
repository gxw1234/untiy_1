/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class SplitBtn : GButton
    {
        public Controller button;
        public GImage Img568rd8;
        public GImage Img569335;
        public GTextField ChatEdit1;
        public const string URL = "ui://us2ut3jfr7r83a";

        public static SplitBtn CreateInstance()
        {
            return (SplitBtn)UIPackage.CreateObject("UILoadingRes", "SplitBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img568rd8 = (GImage)GetChild("Img568rd8");
            Img569335 = (GImage)GetChild("Img569335");
            ChatEdit1 = (GTextField)GetChild("ChatEdit1");
        }
    }
}