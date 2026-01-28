/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Gategory_item : GButton
    {
        public Controller button;
        public GGraph n0;
        public GGraph n1;
        public GTextField title;
        public const string URL = "ui://jk0io98jm9ogk";

        public static Gategory_item CreateInstance()
        {
            return (Gategory_item)UIPackage.CreateObject("UIRes", "Gategory_item");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GGraph)GetChild("n0");
            n1 = (GGraph)GetChild("n1");
            title = (GTextField)GetChild("title");
        }
    }
}