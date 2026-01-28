/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class c7 : GComponent
    {
        public GLoader d7;
        public const string URL = "ui://use7blkkr7r847";

        public static c7 CreateInstance()
        {
            return (c7)UIPackage.CreateObject("BaseRes", "c7");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            d7 = (GLoader)GetChild("d7");
        }
    }
}