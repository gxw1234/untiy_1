/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EControl4 : GComponent
    {
        public GImage DA2EControl4;
        public const string URL = "ui://jk0io98jv9b16g";

        public static DA2EControl4 CreateInstance()
        {
            return (DA2EControl4)UIPackage.CreateObject("UIRes", "DA2EControl4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl4 = (GImage)GetChild("DA2EControl4");
        }
    }
}