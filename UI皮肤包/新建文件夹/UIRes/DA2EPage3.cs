/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EPage3 : GComponent
    {
        public GList n0;
        public const string URL = "ui://jk0io98js46a1a";

        public static DA2EPage3 CreateInstance()
        {
            return (DA2EPage3)UIPackage.CreateObject("UIRes", "DA2EPage3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GList)GetChild("n0");
        }
    }
}