/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Mask : GComponent
    {
        public GGraph maskImg;
        public const string URL = "ui://jk0io98jj3e21ft";

        public static Mask CreateInstance()
        {
            return (Mask)UIPackage.CreateObject("UIRes", "Mask");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            maskImg = (GGraph)GetChild("maskImg");
        }
    }
}