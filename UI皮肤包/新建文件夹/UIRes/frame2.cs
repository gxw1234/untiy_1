/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class frame2 : GComponent
    {
        public GGraph dragArea;
        public const string URL = "ui://jk0io98jkn5z12j";

        public static frame2 CreateInstance()
        {
            return (frame2)UIPackage.CreateObject("UIRes", "frame2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            dragArea = (GGraph)GetChild("dragArea");
        }
    }
}