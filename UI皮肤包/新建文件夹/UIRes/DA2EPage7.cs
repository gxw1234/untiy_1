/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EPage7 : GComponent
    {
        public DA2EWindow1 DA2EWindow1;
        public GList SetList;
        public const string URL = "ui://jk0io98js46an";

        public static DA2EPage7 CreateInstance()
        {
            return (DA2EPage7)UIPackage.CreateObject("UIRes", "DA2EPage7");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow1 = (DA2EWindow1)GetChild("DA2EWindow1");
            SetList = (GList)GetChild("SetList");
        }
    }
}