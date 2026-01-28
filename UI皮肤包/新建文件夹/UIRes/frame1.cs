/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class frame1 : GComponent
    {
        public GGraph dragArea;
        public const string URL = "ui://jk0io98jkn5zxu";

        public static frame1 CreateInstance()
        {
            return (frame1)UIPackage.CreateObject("UIRes", "frame1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            dragArea = (GGraph)GetChild("dragArea");
        }
    }
}