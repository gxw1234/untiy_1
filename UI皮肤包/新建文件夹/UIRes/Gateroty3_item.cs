/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Gateroty3_item : GButton
    {
        public Controller button;
        public GGraph n0;
        public GGraph n1;
        public GTextField title;
        public const string URL = "ui://jk0io98jm9og1d";

        public static Gateroty3_item CreateInstance()
        {
            return (Gateroty3_item)UIPackage.CreateObject("UIRes", "Gateroty3_item");
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