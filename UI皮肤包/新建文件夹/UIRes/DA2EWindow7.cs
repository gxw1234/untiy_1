/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow7 : GComponent
    {
        public GImage DA2EWindow7;
        public const string URL = "ui://jk0io98jkn5zwz";

        public static DA2EWindow7 CreateInstance()
        {
            return (DA2EWindow7)UIPackage.CreateObject("UIRes", "DA2EWindow7");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow7 = (GImage)GetChild("DA2EWindow7");
        }
    }
}