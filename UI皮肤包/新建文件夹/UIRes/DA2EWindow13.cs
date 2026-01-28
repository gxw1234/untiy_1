/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow13 : GComponent
    {
        public GImage DA2EWindow13;
        public const string URL = "ui://jk0io98jkn5zxm";

        public static DA2EWindow13 CreateInstance()
        {
            return (DA2EWindow13)UIPackage.CreateObject("UIRes", "DA2EWindow13");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow13 = (GImage)GetChild("DA2EWindow13");
        }
    }
}