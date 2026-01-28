/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class frame(1) : GComponent
    {
        public GGraph dragArea;
        public const string URL = "ui://jk0io98jj3e21d0";

        public static frame(1) CreateInstance()
        {
            return (frame(1))UIPackage.CreateObject("UIRes", "frame(1)");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            dragArea = (GGraph)GetChild("dragArea");
        }
    }
}