/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow16 : GComponent
    {
        public GImage DA2EWindow16;
        public const string URL = "ui://jk0io98jkn5zxz";

        public static DA2EWindow16 CreateInstance()
        {
            return (DA2EWindow16)UIPackage.CreateObject("UIRes", "DA2EWindow16");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow16 = (GImage)GetChild("DA2EWindow16");
        }
    }
}