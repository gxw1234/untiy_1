/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComboBox1_item : GButton
    {
        public Controller button;
        public GTextField title;
        public const string URL = "ui://jk0io98jkn5zys";

        public static ComboBox1_item CreateInstance()
        {
            return (ComboBox1_item)UIPackage.CreateObject("UIRes", "ComboBox1_item");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            title = (GTextField)GetChild("title");
        }
    }
}