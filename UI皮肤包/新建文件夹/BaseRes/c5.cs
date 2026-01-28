/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class c5 : GComponent
    {
        public GLoader d5;
        public const string URL = "ui://use7blkkr7r845";

        public static c5 CreateInstance()
        {
            return (c5)UIPackage.CreateObject("BaseRes", "c5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            d5 = (GLoader)GetChild("d5");
        }
    }
}