/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComboBox1_popup : GComponent
    {
        public GImage ComboBox1_popup;
        public GList list;
        public const string URL = "ui://jk0io98jkn5zyt";

        public static ComboBox1_popup CreateInstance()
        {
            return (ComboBox1_popup)UIPackage.CreateObject("UIRes", "ComboBox1_popup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            ComboBox1_popup = (GImage)GetChild("ComboBox1_popup");
            list = (GList)GetChild("list");
        }
    }
}