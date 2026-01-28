/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TabBtnAuction : GButton
    {
        public Controller button;
        public GImage Img192eqh;
        public GImage Img191m3s;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z11e";

        public static TabBtnAuction CreateInstance()
        {
            return (TabBtnAuction)UIPackage.CreateObject("UIRes", "TabBtnAuction");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img192eqh = (GImage)GetChild("Img192eqh");
            Img191m3s = (GImage)GetChild("Img191m3s");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}