/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DRAutoSendClose : GButton
    {
        public Controller button;
        public GImage close;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jmz110";

        public static DRAutoSendClose CreateInstance()
        {
            return (DRAutoSendClose)UIPackage.CreateObject("UIRes", "DRAutoSendClose");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            close = (GImage)GetChild("close");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}