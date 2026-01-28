/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class c1 : GComponent
    {
        public GLoader d1;
        public const string URL = "ui://use7blkkr7r841";

        public static c1 CreateInstance()
        {
            return (c1)UIPackage.CreateObject("BaseRes", "c1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            d1 = (GLoader)GetChild("d1");
        }
    }
}