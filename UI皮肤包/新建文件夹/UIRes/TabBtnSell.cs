/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TabBtnSell : GButton
    {
        public Controller button;
        public GImage Img192udi;
        public GImage Img191p87;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z11d";

        public static TabBtnSell CreateInstance()
        {
            return (TabBtnSell)UIPackage.CreateObject("UIRes", "TabBtnSell");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img192udi = (GImage)GetChild("Img192udi");
            Img191p87 = (GImage)GetChild("Img191p87");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}