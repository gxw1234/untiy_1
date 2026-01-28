/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DCharRecoverClose : GButton
    {
        public Controller button;
        public GImage Img041u;
        public GImage Img1o00;
        public const string URL = "ui://jk0io98jy15i8";

        public static DCharRecoverClose CreateInstance()
        {
            return (DCharRecoverClose)UIPackage.CreateObject("UIRes", "DCharRecoverClose");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img041u = (GImage)GetChild("Img041u");
            Img1o00 = (GImage)GetChild("Img1o00");
        }
    }
}