/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EControl5 : GComponent
    {
        public GImage DA2EControl5;
        public const string URL = "ui://jk0io98jv9b16i";

        public static DA2EControl5 CreateInstance()
        {
            return (DA2EControl5)UIPackage.CreateObject("UIRes", "DA2EControl5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl5 = (GImage)GetChild("DA2EControl5");
        }
    }
}