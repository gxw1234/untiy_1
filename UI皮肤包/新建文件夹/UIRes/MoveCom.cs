/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class MoveCom : GComponent
    {
        public GImage msgbg;
        public GTextField msg;
        public const string URL = "ui://jk0io98jv9b1g5";

        public static MoveCom CreateInstance()
        {
            return (MoveCom)UIPackage.CreateObject("UIRes", "MoveCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            msgbg = (GImage)GetChild("msgbg");
            msg = (GTextField)GetChild("msg");
        }
    }
}