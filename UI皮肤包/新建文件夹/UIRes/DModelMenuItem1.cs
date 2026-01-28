/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DModelMenuItem1 : GButton
    {
        public Controller button;
        public GImage Img112j71;
        public GImage Img1137c6;
        public const string URL = "ui://jk0io98jv9b1fn";

        public static DModelMenuItem1 CreateInstance()
        {
            return (DModelMenuItem1)UIPackage.CreateObject("UIRes", "DModelMenuItem1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img112j71 = (GImage)GetChild("Img112j71");
            Img1137c6 = (GImage)GetChild("Img1137c6");
        }
    }
}