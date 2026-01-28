/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class frame : GComponent
    {
        public GGraph dragArea;
        public const string URL = "ui://use7blkkqgn26k";

        public static frame CreateInstance()
        {
            return (frame)UIPackage.CreateObject("BaseRes", "frame");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            dragArea = (GGraph)GetChild("dragArea");
        }
    }
}