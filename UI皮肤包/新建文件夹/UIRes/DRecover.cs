/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DRecover : GButton
    {
        public Controller button;
        public GImage Img24ik1;
        public GImage Img252d2;
        public const string URL = "ui://jk0io98j7whv0";

        public static DRecover CreateInstance()
        {
            return (DRecover)UIPackage.CreateObject("UIRes", "DRecover");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img24ik1 = (GImage)GetChild("Img24ik1");
            Img252d2 = (GImage)GetChild("Img252d2");
        }
    }
}