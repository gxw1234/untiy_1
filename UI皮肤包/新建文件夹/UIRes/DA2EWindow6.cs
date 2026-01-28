/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow6 : GComponent
    {
        public GImage DA2EWindow6;
        public const string URL = "ui://jk0io98jkn5zwx";

        public static DA2EWindow6 CreateInstance()
        {
            return (DA2EWindow6)UIPackage.CreateObject("UIRes", "DA2EWindow6");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow6 = (GImage)GetChild("DA2EWindow6");
        }
    }
}