/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComDown_item : GButton
    {
        public Controller button;
        public GTextField title;
        public const string URL = "ui://jk0io98jfoo97";

        public static ComDown_item CreateInstance()
        {
            return (ComDown_item)UIPackage.CreateObject("UIRes", "ComDown_item");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            title = (GTextField)GetChild("title");
        }
    }
}