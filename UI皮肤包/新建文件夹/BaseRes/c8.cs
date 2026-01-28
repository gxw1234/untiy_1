/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class c8 : GComponent
    {
        public GLoader d8;
        public const string URL = "ui://use7blkkr7r848";

        public static c8 CreateInstance()
        {
            return (c8)UIPackage.CreateObject("BaseRes", "c8");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            d8 = (GLoader)GetChild("d8");
        }
    }
}