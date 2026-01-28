/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EControl6 : GComponent
    {
        public GImage DA2EControl6;
        public const string URL = "ui://jk0io98jv9b16k";

        public static DA2EControl6 CreateInstance()
        {
            return (DA2EControl6)UIPackage.CreateObject("UIRes", "DA2EControl6");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl6 = (GImage)GetChild("DA2EControl6");
        }
    }
}