/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EControl8 : GComponent
    {
        public GImage DA2EControl8;
        public const string URL = "ui://jk0io98jv9b16o";

        public static DA2EControl8 CreateInstance()
        {
            return (DA2EControl8)UIPackage.CreateObject("UIRes", "DA2EControl8");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl8 = (GImage)GetChild("DA2EControl8");
        }
    }
}