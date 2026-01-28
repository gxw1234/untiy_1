/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class BtnPageDown : GButton
    {
        public Controller button;
        public GImage Img43e0;
        public GImage Img5t3p;
        public const string URL = "ui://use7blkkqgn26p";

        public static BtnPageDown CreateInstance()
        {
            return (BtnPageDown)UIPackage.CreateObject("BaseRes", "BtnPageDown");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img43e0 = (GImage)GetChild("Img43e0");
            Img5t3p = (GImage)GetChild("Img5t3p");
        }
    }
}