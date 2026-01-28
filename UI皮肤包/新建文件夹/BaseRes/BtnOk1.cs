/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class BtnOk1 : GButton
    {
        public Controller button;
        public GImage Img1043d;
        public GImage Img11425;
        public GTextField EditBtn;
        public const string URL = "ui://use7blkkqgn26q";

        public static BtnOk1 CreateInstance()
        {
            return (BtnOk1)UIPackage.CreateObject("BaseRes", "BtnOk1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1043d = (GImage)GetChild("Img1043d");
            Img11425 = (GImage)GetChild("Img11425");
            EditBtn = (GTextField)GetChild("EditBtn");
        }
    }
}