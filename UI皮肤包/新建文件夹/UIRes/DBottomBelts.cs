/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBottomBelts : GComponent
    {
        public GImage DBottomBelts;
        public GList bagItemCell;
        public const string URL = "ui://jk0io98jj3e21nw";

        public static DBottomBelts CreateInstance()
        {
            return (DBottomBelts)UIPackage.CreateObject("UIRes", "DBottomBelts");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBottomBelts = (GImage)GetChild("DBottomBelts");
            bagItemCell = (GList)GetChild("bagItemCell");
        }
    }
}