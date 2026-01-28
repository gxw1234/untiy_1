/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow14 : GComponent
    {
        public GImage DA2EWindow14;
        public n1 n1;
        public const string URL = "ui://jk0io98jkn5zxc";

        public static DA2EWindow14 CreateInstance()
        {
            return (DA2EWindow14)UIPackage.CreateObject("UIRes", "DA2EWindow14");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow14 = (GImage)GetChild("DA2EWindow14");
            n1 = (n1)GetChild("n1");
        }
    }
}