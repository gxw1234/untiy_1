/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DGroupApply : GButton
    {
        public Controller button;
        public GImage Img2981m7;
        public GImage Img29774n;
        public const string URL = "ui://jk0io98jkn5ztr";

        public static DGroupApply CreateInstance()
        {
            return (DGroupApply)UIPackage.CreateObject("UIRes", "DGroupApply");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2981m7 = (GImage)GetChild("Img2981m7");
            Img29774n = (GImage)GetChild("Img29774n");
        }
    }
}