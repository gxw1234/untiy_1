/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow22 : GComponent
    {
        public GImage DA2EWindow22;
        public GTextInput CompeteAddPriceVEdit;
        public const string URL = "ui://jk0io98jkn5z131";

        public static DA2EWindow22 CreateInstance()
        {
            return (DA2EWindow22)UIPackage.CreateObject("UIRes", "DA2EWindow22");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow22 = (GImage)GetChild("DA2EWindow22");
            CompeteAddPriceVEdit = (GTextInput)GetChild("CompeteAddPriceVEdit");
        }
    }
}