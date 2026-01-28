/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DStart : GButton
    {
        public Controller button;
        public GImage Img26s8b;
        public GImage Img27041;
        public ProgressBar2 n0;
        public const string URL = "ui://jk0io98j1dhl7";

        public static DStart CreateInstance()
        {
            return (DStart)UIPackage.CreateObject("UIRes", "DStart");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img26s8b = (GImage)GetChild("Img26s8b");
            Img27041 = (GImage)GetChild("Img27041");
            n0 = (ProgressBar2)GetChild("n0");
        }
    }
}