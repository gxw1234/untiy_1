/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EControl3 : GComponent
    {
        public GImage DA2EControl3;
        public const string URL = "ui://jk0io98jv9b16e";

        public static DA2EControl3 CreateInstance()
        {
            return (DA2EControl3)UIPackage.CreateObject("UIRes", "DA2EControl3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl3 = (GImage)GetChild("DA2EControl3");
        }
    }
}