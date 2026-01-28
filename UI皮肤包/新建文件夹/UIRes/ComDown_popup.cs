/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComDown_popup : GComponent
    {
        public GImage ComboBox1_popup;
        public GList list;
        public const string URL = "ui://jk0io98jfoo95";

        public static ComDown_popup CreateInstance()
        {
            return (ComDown_popup)UIPackage.CreateObject("UIRes", "ComDown_popup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            ComboBox1_popup = (GImage)GetChild("ComboBox1_popup");
            list = (GList)GetChild("list");
        }
    }
}