/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class c2 : GComponent
    {
        public GLoader d2;
        public const string URL = "ui://use7blkkr7r842";

        public static c2 CreateInstance()
        {
            return (c2)UIPackage.CreateObject("BaseRes", "c2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            d2 = (GLoader)GetChild("d2");
        }
    }
}