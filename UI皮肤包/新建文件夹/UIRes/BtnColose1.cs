/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnColose1 : GButton
    {
        public Controller button;
        public GImage Img048x;
        public GImage Img1j84;
        public const string URL = "ui://jk0io98jj3e21gi";

        public static BtnColose1 CreateInstance()
        {
            return (BtnColose1)UIPackage.CreateObject("UIRes", "BtnColose1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img048x = (GImage)GetChild("Img048x");
            Img1j84 = (GImage)GetChild("Img1j84");
        }
    }
}