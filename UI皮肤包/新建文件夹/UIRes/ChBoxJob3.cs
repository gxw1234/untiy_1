/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ChBoxJob3 : GButton
    {
        public Controller button;
        public GImage Img1761wo;
        public GImage Img177u21;
        public const string URL = "ui://jk0io98jkn5z16z";

        public static ChBoxJob3 CreateInstance()
        {
            return (ChBoxJob3)UIPackage.CreateObject("UIRes", "ChBoxJob3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1761wo = (GImage)GetChild("Img1761wo");
            Img177u21 = (GImage)GetChild("Img177u21");
        }
    }
}