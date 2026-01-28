/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DLevel : GComponent
    {
        public GImage DLevel;
        public GTextField DLevelText;
        public const string URL = "ui://jk0io98jv9b11d";

        public static DLevel CreateInstance()
        {
            return (DLevel)UIPackage.CreateObject("UIRes", "DLevel");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DLevel = (GImage)GetChild("DLevel");
            DLevelText = (GTextField)GetChild("DLevelText");
        }
    }
}