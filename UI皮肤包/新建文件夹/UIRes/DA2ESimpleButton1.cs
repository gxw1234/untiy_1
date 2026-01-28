/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton1 : GButton
    {
        public Controller button;
        public GImage Img1245xv;
        public GImage Img125c62;
        public const string URL = "ui://jk0io98jtd9gb";

        public static DA2ESimpleButton1 CreateInstance()
        {
            return (DA2ESimpleButton1)UIPackage.CreateObject("UIRes", "DA2ESimpleButton1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1245xv = (GImage)GetChild("Img1245xv");
            Img125c62 = (GImage)GetChild("Img125c62");
        }
    }
}