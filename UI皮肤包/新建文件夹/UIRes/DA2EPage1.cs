/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EPage1 : GComponent
    {
        public GList DA2EGrid2;
        public const string URL = "ui://jk0io98jtd9ge";

        public static DA2EPage1 CreateInstance()
        {
            return (DA2EPage1)UIPackage.CreateObject("UIRes", "DA2EPage1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EGrid2 = (GList)GetChild("DA2EGrid2");
        }
    }
}