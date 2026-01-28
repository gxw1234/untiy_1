/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class joystick_1 : GButton
    {
        public GImage thumb1;
        public const string URL = "ui://jk0io98jgcp1n1pg";

        public static joystick_1 CreateInstance()
        {
            return (joystick_1)UIPackage.CreateObject("UIRes", "joystick_1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            thumb1 = (GImage)GetChild("thumb1");
        }
    }
}