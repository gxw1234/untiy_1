/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class c6 : GComponent
    {
        public GLoader d6;
        public const string URL = "ui://use7blkkr7r846";

        public static c6 CreateInstance()
        {
            return (c6)UIPackage.CreateObject("BaseRes", "c6");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            d6 = (GLoader)GetChild("d6");
        }
    }
}