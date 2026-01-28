/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class frame3 : GComponent
    {
        public GGraph dragArea;
        public const string URL = "ui://jk0io98jkn5z12t";

        public static frame3 CreateInstance()
        {
            return (frame3)UIPackage.CreateObject("UIRes", "frame3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            dragArea = (GGraph)GetChild("dragArea");
        }
    }
}