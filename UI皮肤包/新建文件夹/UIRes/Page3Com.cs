/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page3Com : GComponent
    {
        public GImage n0;
        public GList n2;
        public const string URL = "ui://jk0io98jj3e21cj";

        public static Page3Com CreateInstance()
        {
            return (Page3Com)UIPackage.CreateObject("UIRes", "Page3Com");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            n2 = (GList)GetChild("n2");
        }
    }
}