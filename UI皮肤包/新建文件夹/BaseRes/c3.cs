/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class c3 : GComponent
    {
        public GLoader d3;
        public const string URL = "ui://use7blkkr7r843";

        public static c3 CreateInstance()
        {
            return (c3)UIPackage.CreateObject("BaseRes", "c3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            d3 = (GLoader)GetChild("d3");
        }
    }
}