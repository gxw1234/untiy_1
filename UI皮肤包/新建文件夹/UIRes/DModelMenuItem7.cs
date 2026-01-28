/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DModelMenuItem7 : GButton
    {
        public Controller button;
        public GImage Img1141a0;
        public GImage Img115508;
        public const string URL = "ui://jk0io98jv9b1ft";

        public static DModelMenuItem7 CreateInstance()
        {
            return (DModelMenuItem7)UIPackage.CreateObject("UIRes", "DModelMenuItem7");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1141a0 = (GImage)GetChild("Img1141a0");
            Img115508 = (GImage)GetChild("Img115508");
        }
    }
}