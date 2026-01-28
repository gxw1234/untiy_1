/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DCharSelectClose : GButton
    {
        public Controller button;
        public GImage Img01k8;
        public GImage Img1p51;
        public const string URL = "ui://jk0io98jst764";

        public static DCharSelectClose CreateInstance()
        {
            return (DCharSelectClose)UIPackage.CreateObject("UIRes", "DCharSelectClose");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img01k8 = (GImage)GetChild("Img01k8");
            Img1p51 = (GImage)GetChild("Img1p51");
        }
    }
}