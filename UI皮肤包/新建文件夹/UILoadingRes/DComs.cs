/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DComs : GComponent
    {
        public DServerGreen DServerGreen;
        public DServerRed DServerRed;
        public DA2ESimpleButton2 DA2ESimpleButton2;
        public DA2ESimpleButton3 DA2ESimpleButton3;
        public const string URL = "ui://us2ut3jfr7r82a";

        public static DComs CreateInstance()
        {
            return (DComs)UIPackage.CreateObject("UILoadingRes", "DComs");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DServerGreen = (DServerGreen)GetChild("DServerGreen");
            DServerRed = (DServerRed)GetChild("DServerRed");
            DA2ESimpleButton2 = (DA2ESimpleButton2)GetChild("DA2ESimpleButton2");
            DA2ESimpleButton3 = (DA2ESimpleButton3)GetChild("DA2ESimpleButton3");
        }
    }
}