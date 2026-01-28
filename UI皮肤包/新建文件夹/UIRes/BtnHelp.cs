/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnHelp : GButton
    {
        public Controller button;
        public GImage n3;
        public GImage n4;
        public const string URL = "ui://jk0io98js336l";

        public static BtnHelp CreateInstance()
        {
            return (BtnHelp)UIPackage.CreateObject("UIRes", "BtnHelp");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n3 = (GImage)GetChild("n3");
            n4 = (GImage)GetChild("n4");
        }
    }
}