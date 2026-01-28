/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class StarItem : GComponent
    {
        public GLoader icon;
        public const string URL = "ui://us2ut3jfr7r83k";

        public static StarItem CreateInstance()
        {
            return (StarItem)UIPackage.CreateObject("UILoadingRes", "StarItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            icon = (GLoader)GetChild("icon");
        }
    }
}