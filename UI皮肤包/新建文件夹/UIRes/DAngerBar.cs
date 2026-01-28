/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DAngerBar : GComponent
    {
        public GImage DAngerBar;
        public const string URL = "ui://jk0io98jj3e21nu";

        public static DAngerBar CreateInstance()
        {
            return (DAngerBar)UIPackage.CreateObject("UIRes", "DAngerBar");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DAngerBar = (GImage)GetChild("DAngerBar");
        }
    }
}