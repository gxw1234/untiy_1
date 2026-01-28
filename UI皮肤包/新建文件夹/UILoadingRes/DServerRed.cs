/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DServerRed : GComponent
    {
        public GImage DServerRed;
        public const string URL = "ui://us2ut3jfr7r81m";

        public static DServerRed CreateInstance()
        {
            return (DServerRed)UIPackage.CreateObject("UILoadingRes", "DServerRed");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DServerRed = (GImage)GetChild("DServerRed");
        }
    }
}