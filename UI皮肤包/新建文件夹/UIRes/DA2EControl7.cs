/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EControl7 : GComponent
    {
        public GImage DA2EControl7;
        public const string URL = "ui://jk0io98jv9b16m";

        public static DA2EControl7 CreateInstance()
        {
            return (DA2EControl7)UIPackage.CreateObject("UIRes", "DA2EControl7");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl7 = (GImage)GetChild("DA2EControl7");
        }
    }
}