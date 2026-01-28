/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnPalyerItem : GButton
    {
        public Controller button;
        public GTextField dark_title;
        public GTextField light_title;
        public GImage n4;
        public const string URL = "ui://jk0io98js336gvn2w5";

        public static BtnPalyerItem CreateInstance()
        {
            return (BtnPalyerItem)UIPackage.CreateObject("UIRes", "BtnPalyerItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            dark_title = (GTextField)GetChild("dark_title");
            light_title = (GTextField)GetChild("light_title");
            n4 = (GImage)GetChild("n4");
        }
    }
}