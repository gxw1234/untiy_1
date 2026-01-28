/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DModelMenuItem5 : GButton
    {
        public Controller button;
        public GImage Img110uc6;
        public GImage Img1111oj;
        public const string URL = "ui://jk0io98jv9b1fr";

        public static DModelMenuItem5 CreateInstance()
        {
            return (DModelMenuItem5)UIPackage.CreateObject("UIRes", "DModelMenuItem5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img110uc6 = (GImage)GetChild("Img110uc6");
            Img1111oj = (GImage)GetChild("Img1111oj");
        }
    }
}