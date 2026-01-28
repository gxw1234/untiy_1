/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ContainerCom : GComponent
    {
        public GGraph Stroke;
        public const string URL = "ui://use7blkkqgn28h";

        public static ContainerCom CreateInstance()
        {
            return (ContainerCom)UIPackage.CreateObject("BaseRes", "ContainerCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Stroke = (GGraph)GetChild("Stroke");
        }
    }
}