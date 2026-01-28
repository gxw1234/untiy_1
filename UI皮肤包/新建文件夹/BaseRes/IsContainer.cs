/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class IsContainer : GButton
    {
        public Controller button;
        public GImage Img176c3q;
        public GImage Img177804;
        public const string URL = "ui://use7blkkqgn27q";

        public static IsContainer CreateInstance()
        {
            return (IsContainer)UIPackage.CreateObject("BaseRes", "IsContainer");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img176c3q = (GImage)GetChild("Img176c3q");
            Img177804 = (GImage)GetChild("Img177804");
        }
    }
}