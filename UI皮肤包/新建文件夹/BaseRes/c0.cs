/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class c0 : GComponent
    {
        public GLoader d0;
        public const string URL = "ui://use7blkkr7r840";

        public static c0 CreateInstance()
        {
            return (c0)UIPackage.CreateObject("BaseRes", "c0");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            d0 = (GLoader)GetChild("d0");
        }
    }
}