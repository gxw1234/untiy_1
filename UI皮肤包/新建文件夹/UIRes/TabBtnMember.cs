/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TabBtnMember : GButton
    {
        public Controller button;
        public GImage Img2477x7;
        public GImage Img24678e;
        public const string URL = "ui://jk0io98jkn5z17c";

        public static TabBtnMember CreateInstance()
        {
            return (TabBtnMember)UIPackage.CreateObject("UIRes", "TabBtnMember");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2477x7 = (GImage)GetChild("Img2477x7");
            Img24678e = (GImage)GetChild("Img24678e");
        }
    }
}