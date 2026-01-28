/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class LiteMsg : GComponent
    {
        public GTextField msg;
        public const string URL = "ui://us2ut3jfr7r83h";

        public static LiteMsg CreateInstance()
        {
            return (LiteMsg)UIPackage.CreateObject("UILoadingRes", "LiteMsg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            msg = (GTextField)GetChild("msg");
        }
    }
}