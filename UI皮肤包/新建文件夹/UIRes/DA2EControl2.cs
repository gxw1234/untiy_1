/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EControl2 : GComponent
    {
        public GImage DA2EControl2;
        public const string URL = "ui://jk0io98jv9b16c";

        public static DA2EControl2 CreateInstance()
        {
            return (DA2EControl2)UIPackage.CreateObject("UIRes", "DA2EControl2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl2 = (GImage)GetChild("DA2EControl2");
        }
    }
}