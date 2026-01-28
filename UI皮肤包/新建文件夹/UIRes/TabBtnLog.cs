/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TabBtnLog : GButton
    {
        public Controller button;
        public GImage Img258jik;
        public GImage Img257fd2;
        public const string URL = "ui://jk0io98jkn5z17f";

        public static TabBtnLog CreateInstance()
        {
            return (TabBtnLog)UIPackage.CreateObject("UIRes", "TabBtnLog");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img258jik = (GImage)GetChild("Img258jik");
            Img257fd2 = (GImage)GetChild("Img257fd2");
        }
    }
}