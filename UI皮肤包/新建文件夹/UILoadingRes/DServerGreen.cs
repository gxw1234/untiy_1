/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DServerGreen : GComponent
    {
        public GImage DServerGreen;
        public const string URL = "ui://us2ut3jfr7r81l";

        public static DServerGreen CreateInstance()
        {
            return (DServerGreen)UIPackage.CreateObject("UILoadingRes", "DServerGreen");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DServerGreen = (GImage)GetChild("DServerGreen");
        }
    }
}