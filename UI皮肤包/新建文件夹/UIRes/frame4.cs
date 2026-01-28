/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class frame4 : GComponent
    {
        public GGraph dragArea;
        public const string URL = "ui://jk0io98jkn5z12z";

        public static frame4 CreateInstance()
        {
            return (frame4)UIPackage.CreateObject("UIRes", "frame4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            dragArea = (GGraph)GetChild("dragArea");
        }
    }
}