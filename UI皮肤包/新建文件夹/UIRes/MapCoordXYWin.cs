/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class MapCoordXYWin : GComponent
    {
        public GImage MapCoordBg;
        public GTextField CoordXYText;
        public const string URL = "ui://jk0io98jruoyn2r4";

        public static MapCoordXYWin CreateInstance()
        {
            return (MapCoordXYWin)UIPackage.CreateObject("UIRes", "MapCoordXYWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            MapCoordBg = (GImage)GetChild("MapCoordBg");
            CoordXYText = (GTextField)GetChild("CoordXYText");
        }
    }
}