/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DRAutoSendOpen : GButton
    {
        public Controller button;
        public GImage open;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jmz112";

        public static DRAutoSendOpen CreateInstance()
        {
            return (DRAutoSendOpen)UIPackage.CreateObject("UIRes", "DRAutoSendOpen");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            open = (GImage)GetChild("open");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}