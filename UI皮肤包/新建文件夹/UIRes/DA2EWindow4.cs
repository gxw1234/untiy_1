/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow4 : GComponent
    {
        public GImage DA2EWindow4;
        public const string URL = "ui://jk0io98jkn5zwt";

        public static DA2EWindow4 CreateInstance()
        {
            return (DA2EWindow4)UIPackage.CreateObject("UIRes", "DA2EWindow4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow4 = (GImage)GetChild("DA2EWindow4");
        }
    }
}