/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComboBox2_popup : GComponent
    {
        public GImage ComboBox2_popup;
        public GList list;
        public const string URL = "ui://jk0io98jkn5z13f";

        public static ComboBox2_popup CreateInstance()
        {
            return (ComboBox2_popup)UIPackage.CreateObject("UIRes", "ComboBox2_popup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            ComboBox2_popup = (GImage)GetChild("ComboBox2_popup");
            list = (GList)GetChild("list");
        }
    }
}