/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class MoveComs : GComponent
    {
        public GImage DA2EIMAGE3;
        public GTextField msg;
        public const string URL = "ui://jk0io98jv9b1g6";

        public static MoveComs CreateInstance()
        {
            return (MoveComs)UIPackage.CreateObject("UIRes", "MoveComs");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EIMAGE3 = (GImage)GetChild("DA2EIMAGE3");
            msg = (GTextField)GetChild("msg");
        }
    }
}