/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class c4 : GComponent
    {
        public GLoader d4;
        public const string URL = "ui://use7blkkr7r844";

        public static c4 CreateInstance()
        {
            return (c4)UIPackage.CreateObject("BaseRes", "c4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            d4 = (GLoader)GetChild("d4");
        }
    }
}