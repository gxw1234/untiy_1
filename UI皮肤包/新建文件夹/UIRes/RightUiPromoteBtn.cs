/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RightUiPromoteBtn : GButton
    {
        public Controller button;
        public GImage Img874o1;
        public GImage Img8862q;
        public const string URL = "ui://jk0io98jk02tn1ux";

        public static RightUiPromoteBtn CreateInstance()
        {
            return (RightUiPromoteBtn)UIPackage.CreateObject("UIRes", "RightUiPromoteBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img874o1 = (GImage)GetChild("Img874o1");
            Img8862q = (GImage)GetChild("Img8862q");
        }
    }
}