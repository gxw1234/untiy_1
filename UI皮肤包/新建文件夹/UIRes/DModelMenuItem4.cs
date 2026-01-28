/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DModelMenuItem4 : GButton
    {
        public Controller button;
        public GImage Img10600q;
        public GImage Img10722n;
        public const string URL = "ui://jk0io98jv9b1fq";

        public static DModelMenuItem4 CreateInstance()
        {
            return (DModelMenuItem4)UIPackage.CreateObject("UIRes", "DModelMenuItem4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10600q = (GImage)GetChild("Img10600q");
            Img10722n = (GImage)GetChild("Img10722n");
        }
    }
}