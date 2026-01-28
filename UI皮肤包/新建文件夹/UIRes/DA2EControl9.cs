/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EControl9 : GComponent
    {
        public GImage DA2EControl9;
        public const string URL = "ui://jk0io98jv9b16q";

        public static DA2EControl9 CreateInstance()
        {
            return (DA2EControl9)UIPackage.CreateObject("UIRes", "DA2EControl9");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl9 = (GImage)GetChild("DA2EControl9");
        }
    }
}