/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DRBWorld : GButton
    {
        public Controller button;
        public GImage Img30583q;
        public GImage Img304lv6;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jj3e21ki";

        public static DRBWorld CreateInstance()
        {
            return (DRBWorld)UIPackage.CreateObject("UIRes", "DRBWorld");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img30583q = (GImage)GetChild("Img30583q");
            Img304lv6 = (GImage)GetChild("Img304lv6");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}