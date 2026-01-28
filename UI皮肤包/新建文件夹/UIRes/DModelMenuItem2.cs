/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DModelMenuItem2 : GButton
    {
        public Controller button;
        public GImage Img108b5s;
        public GImage Img109c30;
        public const string URL = "ui://jk0io98jv9b1fo";

        public static DModelMenuItem2 CreateInstance()
        {
            return (DModelMenuItem2)UIPackage.CreateObject("UIRes", "DModelMenuItem2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img108b5s = (GImage)GetChild("Img108b5s");
            Img109c30 = (GImage)GetChild("Img109c30");
        }
    }
}