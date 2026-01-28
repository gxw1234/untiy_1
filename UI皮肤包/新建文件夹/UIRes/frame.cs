/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class frame : GComponent
    {
        public GGraph dragArea;
        public const string URL = "ui://jk0io98jv9b1fu";

        public static frame CreateInstance()
        {
            return (frame)UIPackage.CreateObject("UIRes", "frame");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            dragArea = (GGraph)GetChild("dragArea");
        }
    }
}