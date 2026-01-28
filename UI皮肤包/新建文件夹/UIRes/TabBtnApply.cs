/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TabBtnApply : GButton
    {
        public Controller button;
        public GImage Img260up6;
        public GImage Img259140;
        public const string URL = "ui://jk0io98jkn5z17e";

        public static TabBtnApply CreateInstance()
        {
            return (TabBtnApply)UIPackage.CreateObject("UIRes", "TabBtnApply");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img260up6 = (GImage)GetChild("Img260up6");
            Img259140 = (GImage)GetChild("Img259140");
        }
    }
}