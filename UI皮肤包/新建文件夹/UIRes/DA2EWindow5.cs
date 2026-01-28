/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow5 : GComponent
    {
        public GImage DA2EWindow5;
        public const string URL = "ui://jk0io98jkn5zwv";

        public static DA2EWindow5 CreateInstance()
        {
            return (DA2EWindow5)UIPackage.CreateObject("UIRes", "DA2EWindow5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow5 = (GImage)GetChild("DA2EWindow5");
        }
    }
}