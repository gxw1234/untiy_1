/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TabBtnBuy : GButton
    {
        public Controller button;
        public GImage Img192766;
        public GImage Img1916j6;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z11b";

        public static TabBtnBuy CreateInstance()
        {
            return (TabBtnBuy)UIPackage.CreateObject("UIRes", "TabBtnBuy");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img192766 = (GImage)GetChild("Img192766");
            Img1916j6 = (GImage)GetChild("Img1916j6");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}