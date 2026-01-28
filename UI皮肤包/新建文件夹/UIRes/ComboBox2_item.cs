/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComboBox2_item : GButton
    {
        public Controller button;
        public GTextField title;
        public const string URL = "ui://jk0io98jkn5z13e";

        public static ComboBox2_item CreateInstance()
        {
            return (ComboBox2_item)UIPackage.CreateObject("UIRes", "ComboBox2_item");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            title = (GTextField)GetChild("title");
        }
    }
}