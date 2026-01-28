/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EControl1 : GComponent
    {
        public GImage DA2EControl1;
        public const string URL = "ui://jk0io98jv9b16a";

        public static DA2EControl1 CreateInstance()
        {
            return (DA2EControl1)UIPackage.CreateObject("UIRes", "DA2EControl1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl1 = (GImage)GetChild("DA2EControl1");
        }
    }
}