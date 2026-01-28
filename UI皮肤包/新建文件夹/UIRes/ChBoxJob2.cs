/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ChBoxJob2 : GButton
    {
        public Controller button;
        public GImage Img176217;
        public GImage Img177j35;
        public const string URL = "ui://jk0io98jkn5z16y";

        public static ChBoxJob2 CreateInstance()
        {
            return (ChBoxJob2)UIPackage.CreateObject("UIRes", "ChBoxJob2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img176217 = (GImage)GetChild("Img176217");
            Img177j35 = (GImage)GetChild("Img177j35");
        }
    }
}