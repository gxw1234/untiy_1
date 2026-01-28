/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnSubmit : GButton
    {
        public Controller button;
        public GImage Img341vl;
        public GImage Img35r8q;
        public const string URL = "ui://jk0io98j0ci26";

        public static BtnSubmit CreateInstance()
        {
            return (BtnSubmit)UIPackage.CreateObject("UIRes", "BtnSubmit");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img341vl = (GImage)GetChild("Img341vl");
            Img35r8q = (GImage)GetChild("Img35r8q");
        }
    }
}