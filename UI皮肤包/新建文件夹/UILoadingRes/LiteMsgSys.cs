/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class LiteMsgSys : GComponent
    {
        public GImage LiteMsgSysBg;
        public GTextField msg;
        public const string URL = "ui://us2ut3jfr7r83i";

        public static LiteMsgSys CreateInstance()
        {
            return (LiteMsgSys)UIPackage.CreateObject("UILoadingRes", "LiteMsgSys");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            LiteMsgSysBg = (GImage)GetChild("LiteMsgSysBg");
            msg = (GTextField)GetChild("msg");
        }
    }
}