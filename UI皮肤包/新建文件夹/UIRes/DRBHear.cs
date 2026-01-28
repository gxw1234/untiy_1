/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DRBHear : GButton
    {
        public Controller button;
        public GImage Img305p4w;
        public GImage Img3044k3;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jj3e21km";

        public static DRBHear CreateInstance()
        {
            return (DRBHear)UIPackage.CreateObject("UIRes", "DRBHear");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img305p4w = (GImage)GetChild("Img305p4w");
            Img3044k3 = (GImage)GetChild("Img3044k3");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}