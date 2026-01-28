/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow11 : GComponent
    {
        public GImage DA2EWindow11;
        public const string URL = "ui://jk0io98jkn5zx0";

        public static DA2EWindow11 CreateInstance()
        {
            return (DA2EWindow11)UIPackage.CreateObject("UIRes", "DA2EWindow11");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow11 = (GImage)GetChild("DA2EWindow11");
        }
    }
}